using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Order
{

    public string text { get; set; }
    public string[] type { get; set; }
    public int[][][] runeOrder { get; set; }

    public Order()
    {

    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        Order objAsOrder = obj as Order;

        if (objAsOrder == null)
        {
            return false;
        }
        else
        {
            return Equals(objAsOrder);
        }
    }

    public bool Equals(Order other)
    {
        if (other == null)
        {
            return false;
        }

        if (other.runeOrder[0].Length == 1)
        {
            if (type.Contains(other.type[0]))
            {
                for (int i = 0; i < type.Length; i++)
                {
                    for (int j = 0; j < runeOrder[i].Length; j++)
                    {
                        if (Enumerable.SequenceEqual(runeOrder[i][j], other.runeOrder[0][0]))
                        {
                            return true;
                        }
                    }
                }

            }
        }
        else
        {
            if (other.type.Contains(type[0]))
            {
                for (int i = 0; i < other.type.Length; i++)
                {
                    for (int j = 0; j < other.runeOrder[i].Length; j++)
                    {
                        if (Enumerable.SequenceEqual(runeOrder[0][0], other.runeOrder[i][j]))
                        {
                            return true;
                        }
                    }
                }

            }
        }

        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    /*
    public string GetOrderText()
    {
        return text == null ? "" : text;
    }

    public string[] GetOrderType()
    {
        return type == null ? new string[1] : type;
    }

    public int[][][] GetOrderRuneOrder()
    {
        return runeOrder == null ? new int[1][][] : runeOrder;
    }
    */

}
