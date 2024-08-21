using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderGenerator : MonoBehaviour
{

    //Order[] orders = new Order[1];
    private List<Order> orders = new List<Order>();
    private int startingSize;

    public void Start()
    {
        //Order 0: Arcane:Air/Levitate
        orders.Add(new Order() { 
            text = "Levitate", 
            type = new string[2] { "default", "air" }, 
            runeOrder = new int[2][][] { new int[2][] { new int[8] { 6, 1, 0, 0 , 4, 5, 3, 2 }, new int[8] { 1, 6, 0, 0, 3, 2, 4, 5 } }, new int[2][] { new int[8] { 6, 5, 0, 0, 2, 4, 1, 3 }, new int[8] { 1, 2, 0, 0, 5, 3, 6, 4 } } } 
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

        //Order 8: Fire:Water/Boil/Steam
        orders.Add(new Order()
        {
            text = "Boil/Steam",
            type = new string[2] { "fire", "water" },
            runeOrder = new int[2][][] { new int[2][] { new int[8] { 4, 3, 0, 0, 5, 6, 2, 1 }, new int[8] { 3, 4, 0, 0, 2, 1, 5, 6 } }, new int[2][] { new int[8] { 5, 1, 3, 0, 0, 4, 0, 2 }, new int[8] { 1, 5, 3, 0, 0, 2, 0, 4 } } }
        });

        //Order 9: Fire/Fire Stream
        orders.Add(new Order()
        {
            text = "Fire Stream",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 1, 3, 6, 5, 4, 7, 2 }, new int[8] { 0, 7, 5, 2, 3, 4, 1, 6 } } }
        });

        //Order 10: Fire/Explosion
        orders.Add(new Order()
        {
            text = "Explosion",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 1, 3, 2, 4, 6, 5, 7, 8 }, new int[8] { 8, 6, 7, 5, 3, 4, 2, 1 } } }
        });

        //Order 11: Fire:Nature/Lightning
        orders.Add(new Order()
        {
            text = "Lightning",
            type = new string[2] { "fire", "nature" },
            runeOrder = new int[2][][] { new int[2][] { new int[8] { 3, 2, 1, 4, 0, 0, 0, 0 }, new int[8] { 2, 3, 4, 1, 0, 0, 0, 0 } }, new int[2][] { new int[8] { 3, 4, 2, 6, 0, 7, 5, 1 }, new int[8] { 5, 4, 6, 2, 0, 1, 3, 7 } } }
        });

        //Order 12: Fire/Warm
        orders.Add(new Order()
        {
            text = "Warm",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } } }
        });

        //Order 13: Fire/Burn
        orders.Add(new Order()
        {
            text = "Burn",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 3, 0, 5, 4, 1, 2 }, new int[8] { 0, 0, 3, 0, 1, 2, 5, 4 } } }
        });

        //Order 14: Fire/Cook
        orders.Add(new Order()
        {
            text = "Cook",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 7, 1, 4, 0, 6, 5, 2, 3 }, new int[8] { 1, 7, 4, 0, 2, 3, 6, 5 } } }
        });

        //Order 15: Fire/Ignite
        orders.Add(new Order()
        {
            text = "Ignite",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 4, 3, 1, 2, 0, 0, 0, 0 }, new int[8] { 1, 2, 4, 3, 0, 0, 0, 0 } } }
        });

        //Order 16: Water/Drink
        orders.Add(new Order()
        {
            text = "Drink",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 2, 3, 0, 4, 1, 0 }, new int[8] { 0, 0, 3, 2, 0, 1, 4, 0 } } }
        });

        //Order 17: Water/Create Water
        orders.Add(new Order()
        {
            text = "Create Water",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 2, 5, 3, 6, 1, 4 }, new int[8] { 0, 0, 5, 2, 4, 1, 6, 3 } } }
        });

        //Order 18: Water/Freeze
        orders.Add(new Order()
        {
            text = "Freeze",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 5, 1, 0, 3, 4, 0, 2, 0 }, new int[8] { 1, 5, 0, 3, 2, 0, 4, 0 } } }
        });

        //Order 19: Water/Waterfall
        orders.Add(new Order()
        {
            text = "Waterfall",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 8, 1, 4, 5, 7, 6, 3, 2 }, new int[8] { 1, 8, 5, 4, 2, 3, 6, 7 } } }
        });

        //Order 20: Water/Water Breathing
        orders.Add(new Order()
        {
            text = "Waterbreathing",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 1, 6, 3, 4, 2, 5 }, new int[8] { 0, 0, 6, 1, 4, 3, 5, 2 } } }
        });

        //Order 21: Water/Control Water
        orders.Add(new Order()
        {
            text = "Control Water",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 7, 1, 0, 4, 6, 5, 2, 3 }, new int[8] { 1, 7, 0, 4, 2, 3, 6, 5 } } }
        });

        //Order 22: Water/Rain
        orders.Add(new Order()
        {
            text = "Rain",
            type = new string[2] { "water", "nature" },
            runeOrder = new int[2][][] { new int[2][] { new int[8] { 5, 2, 7, 8, 6, 4, 1, 3 }, new int[8] { 4, 7, 2, 1, 3, 5, 8, 6 } }, new int[2][] { new int[8] { 0, 0, 3, 0, 2, 5, 4, 1 }, new int[8] { 0, 0, 3, 0, 4, 1, 2, 5 } } }
        });

        //Order 23: Nature/Grow
        orders.Add(new Order()
        {
            text = "Grow",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 2, 1, 4, 5, 3, 0 }, new int[8] { 0, 0, 4, 5, 2, 1, 3, 0 } } }
        });

        //Order 24: Nature/Entangle
        orders.Add(new Order()
        {
            text = "Entangle",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 5, 0, 4, 2, 1, 3 }, new int[8] { 0, 0, 1, 0, 2, 4, 5, 3 } } }
        });

        //Order 25: Nature/Speak with Nature
        orders.Add(new Order()
        {
            text = "Speak with Nature",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 3, 2, 5, 4, 1 }, new int[8] { 0, 0, 0, 3, 4, 1, 2, 5 } } }
        });

        //Order 26: Nature/Heal
        orders.Add(new Order()
        {
            text = "Heal",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 2, 6, 4, 0, 5, 7, 3, 1 }, new int[8] { 6, 2, 4, 0, 3, 1, 5, 7 } } }
        });

        //Order 27: Nature/Move Stone
        orders.Add(new Order()
        {
            text = "Move Stone",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 6, 1, 0, 0, 3, 2, 4, 5 }, new int[8] { 1, 6, 0, 0, 4, 5, 3, 2 } } }
        });

        //Order 28: Nature/Earthquake
        orders.Add(new Order()
        {
            text = "Earthquake",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 5, 4, 1, 8, 3, 7, 2, 6 }, new int[8] { 4, 5, 8, 1, 6, 2, 7, 3 } } }
        });

        //Order 29: Nature/Summon Treant
        orders.Add(new Order()
        {
            text = "Summon Treant",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 2, 6, 4, 0, 7, 5, 1, 3 }, new int[8] { 6, 2, 4, 0, 1, 3, 7, 5 } } }
        });

        //Order 30: Air/Tornado
        orders.Add(new Order()
        {
            text = "Tornado",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 5, 3, 0, 4, 6, 7, 2, 1 }, new int[8] { 3, 5, 0, 4, 2, 1, 6, 7 } } }
        });

        //Order 31: Air/Fly
        orders.Add(new Order()
        {
            text = "Fly",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 6, 5, 2, 1, 4, 0, 3, 0 }, new int[8] { 1, 2, 5, 6, 3, 0, 4, 0 } } }
        });

        //Order 32: Air/Wind Scythe
        orders.Add(new Order()
        {
            text = "Wind Scythe",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 6, 1, 3, 2, 5, 7, 4, 8 }, new int[8] { 3, 8, 6, 7, 4, 2, 5, 1 } } }
        });

        //Order 33: Air/Gust Minor
        orders.Add(new Order()
        {
            text = "Gust Minor",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 3, 0, 2, 4, 0, 0, 1, 5 }, new int[8] { 3, 0, 4, 2, 0, 0, 5, 1 } } }
        });

        //Order 34: Air/Gust Major
        orders.Add(new Order()
        {
            text = "Gust Major",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 4, 0, 3, 5, 2, 6, 1, 7 }, new int[8] { 4, 0, 5, 3, 6, 2, 7, 1 } } }
        });

        //Order 35: Air/Stealth Walk
        orders.Add(new Order()
        {
            text = "Stealth Walk",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 4, 3, 0, 0, 0, 2, 0, 1 }, new int[8] { 1, 2, 0, 0, 0, 3, 0, 4 } } }
        });

        //Order 36: Air/Slow Fall
        orders.Add(new Order()
        {
            text = "Slow Fall",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 6, 5, 1, 2, 0, 4, 0, 3 }, new int[8] { 1, 2, 6, 5, 0, 3, 0, 4 } } }
        });

        startingSize = orders.Count;

    }

    public Order GetOrder()
    {
        int index = Random.Range(0, orders.Count);

        var order = orders[index];
        orders.RemoveAt(index);

        return order;
    }

    public int GetOrderSize()
    {
        return orders.Count;
    }

    public int GetOrderStartingSize()
    {
        return startingSize;
    }

}
