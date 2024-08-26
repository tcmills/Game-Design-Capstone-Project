using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Order
{

    public int level { get; set; }
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
            return Check(other, this);
        }
        else
        {
            return Check(this, other);
        }
    }

    private bool Check(Order player, Order answer)
    {
        if (answer.type.Contains(player.type[0]))
        {
            var i = Array.IndexOf(answer.type, player.type[0]);
            for (int j = 0; j < answer.runeOrder[i].Length; j++)
            {
                if (Enumerable.SequenceEqual(answer.runeOrder[i][j], player.runeOrder[0][0]))
                {
                    return true;
                }
            }

        }

        return false;
    }

    public string EqualsWhy(Order other)
    {

        if (other == null)
        {
            return "fOther does not exist.";
        }

        if (other.runeOrder[0].Length == 1)
        {

            return CheckWhy(other, this);

        }
        else
        {

            return CheckWhy(this, other);

        }

    }

    private string CheckWhy(Order player, Order answer)
    {
        int playerEmptyAmount = player.runeOrder[0][0].Count(s => s == 0);
        int playerRPAmount = 8 - playerEmptyAmount;
        
        int closestRPAmount = 0;

        int closestRPPlacement = 0;

        int closestRPOrder = 8;

        bool extra = false;

        if (answer.type.Contains(player.type[0]))
        {

            var i = Array.IndexOf(answer.type, player.type[0]);

            for (int j = 0; j < answer.runeOrder[i].Length; j++)
            {

                string playerRPOrder = "";
                int answerEmptyAmount = answer.runeOrder[i][j].Count(s => s == 0);
                int answerRPAmount = 8 - answerEmptyAmount;
                for (int l = 1; l <= answerRPAmount; l++)
                {
                    playerRPOrder += Array.IndexOf(player.runeOrder[0][0], l);
                }

                if (answerRPAmount - playerRPAmount > 0)
                {
                    closestRPAmount = Mathf.Abs(answerRPAmount - playerRPAmount);
                    extra = false;
                }
                else
                {
                    closestRPAmount = Mathf.Abs(answerRPAmount - playerRPAmount);
                    extra = true;
                }



                var checkRPPlacement = 0;

                for (int k = 0; k < answer.runeOrder[i][j].Length; k++)
                {
                    if ((answer.runeOrder[i][j][k] == 0 && player.runeOrder[0][0][k] != 0))
                    {
                        checkRPPlacement++;
                    }
                }

                if (checkRPPlacement >= closestRPPlacement)
                {
                    closestRPPlacement = checkRPPlacement;
                }



                var answerRPOrder = "";
                var checkRPOrder = answerRPAmount-1;

                for (int l = 1; l <= answerRPAmount; l++)
                {
                    answerRPOrder += Array.IndexOf(answer.runeOrder[i][j], l);
                }

                //Debug.Log(playerRPOrder + ", " + answerRPOrder);
                //Debug.Log(playerRPOrder.Length + ", " + answerRPOrder.Length);
                
                if (playerRPOrder.Length == answerRPOrder.Length)
                {
                    for (int l = 0; l < answerRPAmount-1; l++)
                    {
                        //Debug.Log(playerRPOrder.Substring(l, 2) + ", " + answerRPOrder.Substring(l, 2));
                        if (playerRPOrder.Substring(l, 2) == answerRPOrder.Substring(l, 2))
                        {
                            checkRPOrder--;
                        }
                    }
                }

                if (checkRPOrder <= closestRPOrder)
                {
                    closestRPOrder = checkRPOrder;
                }


                //Debug.Log(closestRPAmount + ", " + closestRPPlacement + ", " + closestRPOrder);
                
            }


            if (closestRPAmount == 0)
            {
                if (closestRPPlacement == 0)
                {
                    if (closestRPOrder == 0)
                    {
                        return "t";
                    }
                    else
                    {
                        return "fIncorrect Rune Order: There are " + closestRPOrder + " rune lines in the wrong order.";
                    }
                }
                else
                {
                    return "fIncorrect Rune Placement: There are " + closestRPPlacement + " rune points in the wrong place.";
                }
            }
            else
            {
                if (extra)
                {
                    return "fIncorrect Rune Amount: There are " + closestRPAmount + " extra rune points";
                }
                else
                {
                    return "fIncorrect Rune Amount: There are " + closestRPAmount + " missing rune points";
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
