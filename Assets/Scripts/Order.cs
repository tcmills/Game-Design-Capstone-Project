using System;
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
            if (Equals(objAsOrder).Substring(0,1) == "t")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public string Equals(Order other)
    {

        if (other == null)
        {
            return "fOther does not exist.";
        }

        if (other.runeOrder[0].Length == 1)
        {

            return Check(other, this);

        }
        else
        {

            return Check(this, other);

        }

        return "t";
    }

    private string Check(Order player, Order answer)
    {
        int closestCorrectOrder = 0;
        int closestCorrectPoints = 0;
        int emptyPoints = 0;
        bool extra = false;
        emptyPoints = player.runeOrder[0][0].Count(s => s == 0);

        if (answer.type.Contains(player.type[0]))
        {

            var i = Array.IndexOf(answer.type, player.type[0]);

            for (int j = 0; j < answer.runeOrder[i].Length; j++)
            {
                //if (Enumerable.SequenceEqual(runeOrder[i][j], other.runeOrder[0][0]))
                //{
                //    return reason;
                //}

                var correctOrder = 0;
                var correctEmptyPoints = 0;

                for (int k = 0; k < answer.runeOrder[i][j].Length; k++)
                {

                    if (answer.runeOrder[i][j][k] == 0)
                    {
                        correctEmptyPoints++;
                    }

                    if (answer.runeOrder[i][j][k] == player.runeOrder[0][0][k])
                    {
                        correctOrder++;
                    }
                }

                if (correctOrder == 8)
                {
                    return "t";
                }
                else if (correctOrder >= closestCorrectOrder)
                {
                    closestCorrectOrder = correctOrder;
                    if (correctEmptyPoints - emptyPoints > 0)
                    {
                        closestCorrectPoints = Mathf.Abs(correctEmptyPoints - emptyPoints);
                        extra = true;
                    }
                    else
                    {
                        closestCorrectPoints = Mathf.Abs(correctEmptyPoints - emptyPoints);
                        extra = false;
                    }
                }
            }

            if (closestCorrectPoints == 0)
            {
                return "fIncorrect Order: " + (8 - closestCorrectOrder) + " rune points deviate from order.";
            }
            else
            {
                if (extra)
                {
                    return "fIncorrect Rune Point: There are " + (closestCorrectPoints) + " extra rune points and " + (8 - closestCorrectOrder) + " rune points deviate from order.";
                }
                else
                {
                    return "fIncorrect Rune Point: There are " + (closestCorrectPoints) + " missing rune points and " + (8 - closestCorrectOrder - closestCorrectPoints) + " rune points deviate from order.";
                }
            }

        }
        else
        {
            return "fThis spell requires a different element.";
        }
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

}
