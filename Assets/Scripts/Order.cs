using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order
{

    public string text;
    public string[] type;
    public int[][][] runeOrder;

    public Order()
    {

    }

    public void SetOrderText(string orderText)
    {
        text = orderText;
    }

    public string GetOrderText()
    {
        return text == null ? "" : text;
    }

    public void SetOrderType(string[] orderType)
    {
        type = orderType;
    }

    public string[] GetOrderType()
    {
        return type == null ? new string[1] : type;
    }

    public void SetOrderRuneOrder(int[][][] orderRuneOrder)
    {
        runeOrder = orderRuneOrder;
    }

    public int[][][] GetOrderRuneOrder()
    {
        return runeOrder == null ? new int[1][][] : runeOrder;
    }

}
