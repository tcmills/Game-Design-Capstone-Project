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

    public void OnPointerClick(PointerEventData eventData)
    {
        if (orderPromptUI != null && spellManager != null && orderGenerator != null && spellManager.canSubmit == false)
        {
            audioSource.Play();
            var firstOrder = orderGenerator.GetOrderStartingSize() == orderGenerator.GetOrderSize();
            var secondOrder = (orderGenerator.GetOrderStartingSize() - orderGenerator.GetOrderSize()) == 1;


            //Debug.Log("" + order.GetOrderText());
            //Debug.Log("" + order.GetOrderType());
            //Debug.Log("" + order.GetOrderRuneOrder());

            if (firstOrder)
            {
                order = orderGenerator.GetArcaneOrder();
                if (order.type.Length == 2)
                {
                    order.type = new string[1] { order.type[0] };
                    order.runeOrder = new int[1][][] { order.runeOrder[0] };
                }
                text.text = order.text + ". Also, don't use any materials. Arcane spells don't need 'em, and I don't want to pay any extra.";
            }
            else if (secondOrder)
            {
                order = orderGenerator.GetNotArcaneOrder();
                text.text = order.text + ". Don't forget to add the correct gem to your spellbook. It would be really bad if I blew up my tower again.";
            }
            else
            {
                order = orderGenerator.GetOrder();
                text.text = order.text;
            }

            spellManager.ActivateNPC();
            spellManager.SetAnswer(order);
            spellManager.canSubmit = true;
            orderPromptUI.SetActive(true);

            if (!spellManager.timerStarted)
            {
                StartCoroutine(spellManager.TimeLimit());
                StartCoroutine(spellManager.SunMove());
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
