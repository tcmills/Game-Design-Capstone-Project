using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class StartOrder : MonoBehaviour, IPointerClickHandler
{

    public GameObject orderPromptUI;
    private TMP_Text text;
    public SpellManager spellManager;
    public OrderGenerator orderGenerator;
    private Order order;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (orderPromptUI != null && spellManager != null && orderGenerator != null)
        {
            order = orderGenerator.GetOrder(0);

            //Debug.Log("" + order.GetOrderText());
            //Debug.Log("" + order.GetOrderType());
            //Debug.Log("" + order.GetOrderRuneOrder());

            text.text = order.GetOrderText();
            spellManager.SetAnswer(order.GetOrderType(), order.GetOrderRuneOrder());
            orderPromptUI.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        text = orderPromptUI.transform.GetChild(1).gameObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
