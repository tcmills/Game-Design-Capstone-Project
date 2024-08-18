using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderGenerator : MonoBehaviour
{

    //Order[] orders = new Order[1];
    List<Order> orders = new List<Order>();

    public void Start()
    {
        //Order 0: Arcane:Air/Levitate
        orders.Add(new Order() { 
            text = "Levitate", 
            type = new string[2] { "default", "air" }, 
            runeOrder = new int[2][][] { new int[2][] { new int[8] { 6, 1, 0, 0 , 4, 5, 3, 2 }, new int[8] { 1, 6, 0, 0, 3, 2, 4, 5 } }, new int[2][] { new int[8] { 6, 1, 0, 0, 4, 5, 3, 2 }, new int[8] { 1, 6, 0, 0, 3, 2, 4, 5 } } } 
        });

        //Order 1: Arcane/MagicMissile
        orders.Add(new Order()
        {
            text = "Magic Missile",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 6, 2, 4, 0, 7, 5, 1, 3 }, new int[8] { 2, 6, 4, 0, 1, 3, 7, 5 } } }
        });

        //Order 2: Arcane/Teleport
        orders.Add(new Order()
        {
            text = "Teleport",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 3, 1, 2, 0, 0, 4, 0, 5 }, new int[8] { 3, 5, 4, 0, 0, 2, 0, 1 } } }
        });

        //Order 3: Arcane/Slow
        orders.Add(new Order()
        {
            text = "Slow",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 4, 3, 0, 2, 0, 1 }, new int[8] { 0, 0, 1, 2, 0, 3, 0, 4 } } }
        });

        //Order 4: Arcane/Haste
        orders.Add(new Order()
        {
            text = "Haste",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 3, 4, 2, 0, 1, 0 }, new int[8] { 0, 0, 2, 1, 3, 0, 4, 0 } } }
        });

        //Order 5: Arcane/Shield
        orders.Add(new Order()
        {
            text = "Shield",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 1, 2, 5, 6, 4, 3 }, new int[8] { 0, 0, 6, 5, 2, 1, 3, 4 } } }
        });

        //Order 6: Arcane/Armor
        orders.Add(new Order()
        {
            text = "Armor",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 3, 5, 4, 6, 0, 2, 1, 0 }, new int[8] { 4, 2, 3, 1, 0, 5, 6, 0 } } }
        });

        //Order 7: Arcane/Invisibility
        orders.Add(new Order()
        {
            text = "Invisibility",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 4, 3, 0, 0, 6, 2, 5, 1 }, new int[8] { 3, 4, 0, 0, 1, 5, 2, 6 } } }
        });

    }

    public Order GetOrder()
    {
        int index = Random.Range(0, orders.Count);

        var order = orders[index];
        orders.RemoveAt(index);

        return order;
    }

}
