using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderGenerator : MonoBehaviour
{

    //Order[] orders = new Order[1];
    //private List<Order> orders = new List<Order>();
    //private List<Order> easyOrders = new List<Order>();
    //private List<Order> mediumOrders = new List<Order>();
    //private List<Order> hardOrders = new List<Order>();
    private List<Order> day1Orders = new List<Order>();
    private List<Order> day2Orders = new List<Order>();
    private List<Order> day3Orders = new List<Order>();
    private List<Order> arcaneOrders1 = new List<Order>();
    private List<Order> arcaneOrders2 = new List<Order>();
    private List<Order> fireOrders1 = new List<Order>();
    private List<Order> fireOrders2 = new List<Order>();
    private List<Order> fireOrders3 = new List<Order>();
    private List<Order> waterOrders1 = new List<Order>();
    private List<Order> waterOrders2 = new List<Order>();
    private List<Order> waterOrders3 = new List<Order>();
    private List<Order> natureOrders1 = new List<Order>();
    private List<Order> natureOrders2 = new List<Order>();
    private List<Order> natureOrders3 = new List<Order>();
    private List<Order> airOrders1 = new List<Order>();
    private List<Order> airOrders2 = new List<Order>();
    private List<Order> airOrders3 = new List<Order>();
    //private List<Order> notArcaneOrders = new List<Order>();
    private int day1StartingSize;
    private int day2StartingSize;
    private int day3StartingSize;

    public void Start()
    {
        //Order 0: Arcane:Air/Levitate
        arcaneOrders1.Add(new Order() { 
            text = "Levitate", 
            type = new string[2] { "default", "air" }, 
            runeOrder = new int[2][][] { new int[2][] { new int[8] { 6, 1, 0, 0 , 4, 5, 3, 2 }, new int[8] { 1, 6, 0, 0, 3, 2, 4, 5 } }, new int[2][] { new int[8] { 6, 5, 0, 0, 2, 4, 1, 3 }, new int[8] { 1, 2, 0, 0, 5, 3, 6, 4 } } } 
        });

        //Order 1: Arcane/MagicMissile
        arcaneOrders2.Add(new Order()
        {
            text = "Magic Missile",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 6, 2, 4, 0, 7, 5, 1, 3 }, new int[8] { 2, 6, 4, 0, 1, 3, 7, 5 } } }
        });

        //Order 2: Arcane/Teleport
        arcaneOrders1.Add(new Order()
        {
            text = "Teleport",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 3, 1, 2, 0, 0, 4, 0, 5 }, new int[8] { 3, 5, 4, 0, 0, 2, 0, 1 } } }
        });

        //Order 3: Arcane/Slow
        arcaneOrders1.Add(new Order()
        {
            text = "Slow",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 4, 3, 0, 2, 0, 1 }, new int[8] { 0, 0, 1, 2, 0, 3, 0, 4 } } }
        });

        //Order 4: Arcane/Haste
        arcaneOrders1.Add(new Order()
        {
            text = "Haste",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 3, 4, 2, 0, 1, 0 }, new int[8] { 0, 0, 2, 1, 3, 0, 4, 0 } } }
        });

        //Order 5: Arcane/Shield
        arcaneOrders2.Add(new Order()
        {
            text = "Shield",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 1, 2, 5, 6, 4, 3 }, new int[8] { 0, 0, 6, 5, 2, 1, 3, 4 } } }
        });

        //Order 6: Arcane/MagicArmor
        arcaneOrders2.Add(new Order()
        {
            text = "Magic Armor",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 3, 5, 4, 6, 0, 2, 1, 0 }, new int[8] { 4, 2, 3, 1, 0, 5, 6, 0 } } }
        });

        //Order 7: Arcane/Invisibility
        arcaneOrders2.Add(new Order()
        {
            text = "Invisibility",
            type = new string[1] { "default" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 4, 3, 0, 0, 6, 2, 5, 1 }, new int[8] { 3, 4, 0, 0, 1, 5, 2, 6 } } }
        });

        //Order 8: Fire:Water/Boil/Steam
        fireOrders2.Add(new Order()
        {
            text = "Boil/Steam",
            type = new string[2] { "fire", "water" },
            runeOrder = new int[2][][] { new int[2][] { new int[8] { 4, 3, 0, 0, 5, 6, 2, 1 }, new int[8] { 3, 4, 0, 0, 2, 1, 5, 6 } }, new int[2][] { new int[8] { 5, 1, 3, 0, 0, 4, 0, 2 }, new int[8] { 1, 5, 3, 0, 0, 2, 0, 4 } } }
        });

        //Order 9: Fire/Fire Stream
        fireOrders3.Add(new Order()
        {
            text = "Fire Stream",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 1, 3, 6, 5, 4, 7, 2 }, new int[8] { 0, 7, 5, 2, 3, 4, 1, 6 } } }
        });

        //Order 10: Fire/Explosion
        fireOrders3.Add(new Order()
        {
            text = "Explosion",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 1, 3, 2, 4, 6, 5, 7, 8 }, new int[8] { 8, 6, 7, 5, 3, 4, 2, 1 } } }
        });

        //Order 11: Fire:Nature/Lightning
        fireOrders1.Add(new Order()
        {
            text = "Lightning",
            type = new string[2] { "fire", "nature" },
            runeOrder = new int[2][][] { new int[2][] { new int[8] { 3, 2, 1, 4, 0, 0, 0, 0 }, new int[8] { 2, 3, 4, 1, 0, 0, 0, 0 } }, new int[2][] { new int[8] { 3, 4, 2, 6, 0, 7, 5, 1 }, new int[8] { 5, 4, 6, 2, 0, 1, 3, 7 } } }
        });

        //Order 12: Fire/Warm
        fireOrders1.Add(new Order()
        {
            text = "Warm",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } } }
        });

        //Order 13: Fire/Burn
        fireOrders1.Add(new Order()
        {
            text = "Burn",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 3, 0, 5, 4, 1, 2 }, new int[8] { 0, 0, 3, 0, 1, 2, 5, 4 } } }
        });

        //Order 14: Fire/Cook
        fireOrders2.Add(new Order()
        {
            text = "Cook",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 7, 1, 4, 0, 6, 5, 2, 3 }, new int[8] { 1, 7, 4, 0, 2, 3, 6, 5 } } }
        });

        //Order 15: Fire/Ignite
        fireOrders1.Add(new Order()
        {
            text = "Ignite",
            type = new string[1] { "fire" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 4, 3, 1, 2, 0, 0, 0, 0 }, new int[8] { 1, 2, 4, 3, 0, 0, 0, 0 } } }
        });

        //Order 16: Water/Drink
        waterOrders1.Add(new Order()
        {
            text = "Drink",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 2, 3, 0, 4, 1, 0 }, new int[8] { 0, 0, 3, 2, 0, 1, 4, 0 } } }
        });

        //Order 17: Water/Create Water
        waterOrders1.Add(new Order()
        {
            text = "Create Water",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 2, 5, 3, 6, 1, 4 }, new int[8] { 0, 0, 5, 2, 4, 1, 6, 3 } } }
        });

        //Order 18: Water/Freeze
        waterOrders1.Add(new Order()
        {
            text = "Freeze",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 5, 1, 0, 3, 4, 0, 2, 0 }, new int[8] { 1, 5, 0, 3, 2, 0, 4, 0 } } }
        });

        //Order 19: Water/Waterfall
        waterOrders3.Add(new Order()
        {
            text = "Waterfall",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 8, 1, 4, 5, 7, 6, 3, 2 }, new int[8] { 1, 8, 5, 4, 2, 3, 6, 7 } } }
        });

        //Order 20: Water/Water Breathing
        waterOrders1.Add(new Order()
        {
            text = "Waterbreathing",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 1, 6, 3, 4, 2, 5 }, new int[8] { 0, 0, 6, 1, 4, 3, 5, 2 } } }
        });

        //Order 21: Water/Control Water
        waterOrders2.Add(new Order()
        {
            text = "Control Water",
            type = new string[1] { "water" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 7, 1, 0, 4, 6, 5, 2, 3 }, new int[8] { 1, 7, 0, 4, 2, 3, 6, 5 } } }
        });

        //Order 22: Water/Rain
        waterOrders2.Add(new Order()
        {
            text = "Rain",
            type = new string[2] { "water", "nature" },
            runeOrder = new int[2][][] { new int[2][] { new int[8] { 5, 2, 7, 8, 6, 4, 1, 3 }, new int[8] { 4, 7, 2, 1, 3, 5, 8, 6 } }, new int[2][] { new int[8] { 0, 0, 3, 0, 2, 5, 4, 1 }, new int[8] { 0, 0, 3, 0, 4, 1, 2, 5 } } }
        });

        //Order 23: Nature/Grow
        natureOrders1.Add(new Order()
        {
            text = "Grow",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 2, 1, 4, 5, 3, 0 }, new int[8] { 0, 0, 4, 5, 2, 1, 3, 0 } } }
        });

        //Order 24: Nature/Entangle
        natureOrders1.Add(new Order()
        {
            text = "Entangle",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 5, 0, 4, 2, 1, 3 }, new int[8] { 0, 0, 1, 0, 2, 4, 5, 3 } } }
        });

        //Order 25: Nature/Speak with Nature
        natureOrders2.Add(new Order()
        {
            text = "Speak with Nature",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 0, 0, 0, 3, 2, 5, 4, 1 }, new int[8] { 0, 0, 0, 3, 4, 1, 2, 5 } } }
        });

        //Order 26: Nature/Heal
        natureOrders2.Add(new Order()
        {
            text = "Heal",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 3, 5, 0, 4, 2, 7, 6, 1 }, new int[8] { 5, 3, 0, 4, 6, 1, 2, 7 } } }
        });

        //Order 27: Nature/Move Stone
        natureOrders2.Add(new Order()
        {
            text = "Move Stone",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 6, 1, 0, 0, 3, 2, 4, 5 }, new int[8] { 1, 6, 0, 0, 4, 5, 3, 2 } } }
        });

        //Order 28: Nature/Earthquake
        natureOrders3.Add(new Order()
        {
            text = "Earthquake",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 5, 4, 1, 8, 3, 7, 2, 6 }, new int[8] { 4, 5, 8, 1, 6, 2, 7, 3 } } }
        });

        //Order 29: Nature/Summon Treant
        natureOrders3.Add(new Order()
        {
            text = "Summon Treant",
            type = new string[1] { "nature" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 2, 6, 4, 0, 7, 5, 1, 3 }, new int[8] { 6, 2, 4, 0, 1, 3, 7, 5 } } }
        });

        //Order 30: Air/Tornado
        airOrders2.Add(new Order()
        {
            text = "Tornado",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 5, 3, 0, 4, 6, 7, 2, 1 }, new int[8] { 3, 5, 0, 4, 2, 1, 6, 7 } } }
        });

        //Order 31: Air/Fly
        airOrders2.Add(new Order()
        {
            text = "Fly",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 6, 5, 2, 1, 4, 0, 3, 0 }, new int[8] { 1, 2, 5, 6, 3, 0, 4, 0 } } }
        });

        //Order 32: Air/Wind Scythe
        airOrders3.Add(new Order()
        {
            text = "Wind Scythe",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 6, 1, 3, 2, 5, 7, 4, 8 }, new int[8] { 3, 8, 6, 7, 4, 2, 5, 1 } } }
        });

        //Order 33: Air/Gust Minor
        airOrders1.Add(new Order()
        {
            text = "Gust Minor",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 3, 0, 2, 4, 0, 0, 1, 5 }, new int[8] { 3, 0, 4, 2, 0, 0, 5, 1 } } }
        });

        //Order 34: Air/Gust Major
        airOrders2.Add(new Order()
        {
            text = "Gust Major",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 4, 0, 3, 5, 2, 6, 1, 7 }, new int[8] { 4, 0, 5, 3, 6, 2, 7, 1 } } }
        });

        //Order 35: Air/Stealth Walk
        airOrders1.Add(new Order()
        {
            text = "Stealth Walk",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 4, 3, 0, 0, 0, 2, 0, 1 }, new int[8] { 1, 2, 0, 0, 0, 3, 0, 4 } } }
        });

        //Order 36: Air/Slow Fall
        airOrders2.Add(new Order()
        {
            text = "Slow Fall",
            type = new string[1] { "air" },
            runeOrder = new int[1][][] { new int[2][] { new int[8] { 6, 5, 1, 2, 0, 4, 0, 3 }, new int[8] { 1, 2, 6, 5, 0, 3, 0, 4 } } }
        });

        day1Orders.AddRange(arcaneOrders1);
        day1Orders.AddRange(fireOrders1);
        day1Orders.AddRange(waterOrders1);
        day1Orders.AddRange(natureOrders1);
        day1Orders.AddRange(airOrders1);

        day2Orders.AddRange(day1Orders);
        day2Orders.AddRange(arcaneOrders2);
        day2Orders.AddRange(fireOrders2);
        day2Orders.AddRange(waterOrders2);
        day2Orders.AddRange(natureOrders2);
        day2Orders.AddRange(airOrders2);

        day3Orders.AddRange(arcaneOrders2);
        day3Orders.AddRange(fireOrders2);
        day3Orders.AddRange(waterOrders2);
        day3Orders.AddRange(natureOrders2);
        day3Orders.AddRange(airOrders2);
        day3Orders.AddRange(fireOrders3);
        day3Orders.AddRange(waterOrders3);
        day3Orders.AddRange(natureOrders3);
        day3Orders.AddRange(airOrders3);

        day1StartingSize = day1Orders.Count;
        day2StartingSize = day1Orders.Count;
        day3StartingSize = day1Orders.Count;

    }

    public Order GetOrder(int day)
    {
        Order order = new Order();

        if (day == 1)
        {
            int index = Random.Range(0, day1Orders.Count);

            order = day1Orders[index];
            day1Orders.RemoveAt(index);
        }
        else if (day == 2)
        {
            int index = Random.Range(0, day2Orders.Count);

            order = day2Orders[index];
            day2Orders.RemoveAt(index);
        }
        else if (day == 3)
        {
            int index = Random.Range(0, day3Orders.Count);

            order = day3Orders[index];
            day3Orders.RemoveAt(index);
        }

        return order;
    }

    public Order GetDay1ArcaneOrder()
    {
        int index = Random.Range(0, arcaneOrders1.Count);

        var order = arcaneOrders1[index];
        arcaneOrders1.RemoveAt(index);
        day1Orders.Remove(order);

        return order;
    }
    public Order GetDay1NotArcaneOrder()
    {
        Order order = new Order();
        int element = Random.Range(0, 4);

        if (element == 0)
        {
            int index = Random.Range(0, fireOrders1.Count);
            order = fireOrders1[index];
            fireOrders1.RemoveAt(index);
        }
        else if (element == 1)
        {
            int index = Random.Range(0, waterOrders1.Count);
            order = waterOrders1[index];
            waterOrders1.RemoveAt(index);
        }
        else if (element == 2)
        {
            int index = Random.Range(0, natureOrders1.Count);
            order = natureOrders1[index];
            natureOrders1.RemoveAt(index);
        }
        else if (element == 3)
        {
            int index = Random.Range(0, natureOrders1.Count);
            order = airOrders1[index];
            airOrders1.RemoveAt(index);
        }

        
        day1Orders.Remove(order);

        return order;
    }

    public int GetOrderSize(int day)
    {
        if (day == 1)
        {
            return day1Orders.Count;
        }
        else if (day == 2)
        {
            return day2Orders.Count;
        }
        else if (day == 3)
        {
            return day3Orders.Count;
        }

        return 0;

    }

    public int GetOrderStartingSize(int day)
    {
        if (day == 1)
        {
            return day1StartingSize;
        }
        else if (day == 2)
        {
            return day2StartingSize;
        }
        else if (day == 3)
        {
            return day3StartingSize;
        }

        return 0;
    }

}
