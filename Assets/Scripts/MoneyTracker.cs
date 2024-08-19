using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyTracker : MonoBehaviour
{

    private TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    public void AddMoney(int add)
    {
        var amount = int.Parse(text.text);
        amount += add;
        text.text = "" + amount;
    }

    public void SubMoney(int sub)
    {
        var amount = int.Parse(text.text);
        amount -= sub;
        text.text = "" + amount;
    }

    public void SetMoney(int set)
    {
        text.text = "" + set;
    }

    public string GetMoney()
    {
        return text.text;
    }
}
