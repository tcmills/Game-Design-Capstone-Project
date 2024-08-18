using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderGenerator : MonoBehaviour
{

    //Order[] orders = new Order[1];
    List<Order> orders = new List<Order>();

    public void Start()
    {
        //Order 0: Arcane/Levitate
        orders.Add(new Order() { 
            text = "Levitate", 
            type = new string[2] { "default", "air" }, 
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } } } 
        });

        //Order 1: Arcane/MagicMissile
        orders.Add(new Order()
        {
            text = "Magic Missile",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } } }
        });

        //Order 2: Arcane/Teleport
        orders.Add(new Order()
        {
            text = "Teleport",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } } }
        });

        //Order 3: Arcane/Slow
        orders.Add(new Order()
        {
            text = "Slow",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } } }
        });

        //Order 4: Arcane/Haste
        orders.Add(new Order()
        {
            text = "Haste",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } } }
        });

        //Order 5: Arcane/Shield
        orders.Add(new Order()
        {
            text = "Shield",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } } }
        });

        //Order 6: Arcane/Armor
        orders.Add(new Order()
        {
            text = "Armor",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } } }
        });

        //Order 7: Arcane/Invisibility
        orders.Add(new Order()
        {
            text = "Invisibility",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } } }
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
