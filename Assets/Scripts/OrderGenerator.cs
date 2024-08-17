using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderGenerator : MonoBehaviour
{

    Order[] orders = new Order[1];
    Order order = new Order();

    public void Start()
    {
        order.SetOrderText("Want <color=red>red</color> rune shaped like a 'V'");
        order.SetOrderType("fire");
        int[][] runeOrder0 = { new int[8] { 0, 0, 0, 2, 3, 0, 1, 0 }, new int[8] { 0, 0, 0, 2, 1, 0, 3, 0 } };
        order.SetOrderRuneOrder(runeOrder0);

        orders[0] = order;
    }

    public Order GetOrder(int index)
    {
        return orders[index];
    }

}
