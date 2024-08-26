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

    public void OnPointerClick(PointerEventData eventData)
    {
        if (orderPromptUI != null && spellManager != null && orderGenerator != null && spellManager.canSubmit == false)
        {
            audioSource.Play();

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
                }
                else if (secondOrder)
                {
                    order = orderGenerator.GetDay1NotArcaneOrder();
                    text.text = order.text;// + " Don't forget to add the correct gem to your spellbook. It would be really bad if I blew up my tower again.";
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
