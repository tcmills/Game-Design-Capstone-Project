using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class StartOrder : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject orderPromptUI;
    private TMP_Text text;
    public SpellManager spellManager;
    public OrderGenerator orderGenerator;
    private Order order;
    private AudioSource audioSource;
    private CrystalLightControl light;
    public DayManager dayManager;
    public GameObject info1;
    public GameObject info2;
    public GameObject info3;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (orderPromptUI != null && spellManager != null && orderGenerator != null && spellManager.canSubmit == false)
        {
            audioSource.Play();
            info1.SetActive(false);

            if (DayManager.day == 1)
            {
                var firstOrder = orderGenerator.GetOrderStartingSize(DayManager.day) == orderGenerator.GetOrderSize(DayManager.day);
                var secondOrder = (orderGenerator.GetOrderStartingSize(DayManager.day) - orderGenerator.GetOrderSize(DayManager.day)) == 1;

                if (firstOrder)
                {
                    order = orderGenerator.GetDay1ArcaneOrder();
                    if (order.type.Length == 2)
                    {
                        order.type = new string[1] { order.type[0] };
                        order.runeOrder = new int[1][][] { order.runeOrder[0] };
                    }
                    text.text = order.text;// + " Also, don't use any gems. Arcane spells don't need 'em, and I don't want to pay any extra.";
                    info2.SetActive(true);
                }
                else if (secondOrder)
                {
                    order = orderGenerator.GetDay1NotArcaneOrder();
                    text.text = order.text;// + " Don't forget to add the correct gem to your spellbook. It would be really bad if I blew up my tower again.";
                    info3.SetActive(true);
                }
                else
                {
                    order = orderGenerator.GetOrder(DayManager.day);
                    text.text = order.text;
                }
            }
            else
            {
                order = orderGenerator.GetOrder(DayManager.day);
                text.text = order.text;
            }


            spellManager.ActivateNPC();
            spellManager.SetAnswer(order);
            spellManager.canSubmit = true;
            orderPromptUI.SetActive(true);

            if (!spellManager.timerStarted)
            {
                StartCoroutine(spellManager.TimeLimit());
                spellManager.timerStarted = true;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        text = orderPromptUI.transform.GetChild(1).gameObject.GetComponent<TMP_Text>();
        audioSource = GetComponent<AudioSource>();
        light = transform.GetChild(3).gameObject.GetComponent<CrystalLightControl>();
        if (DayManager.day == 1)
        {
            info1.SetActive(true);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        light.SetPointerOn(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        light.SetPointerOn(false);
    }
}
