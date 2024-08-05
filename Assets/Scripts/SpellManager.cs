using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour
{

    private GameObject runePoint0;
    private GameObject runePoint1;
    private GameObject runePoint2;
    private GameObject runePoint3;
    private GameObject runePoint4;
    private GameObject runePoint5;
    private GameObject runePoint6;
    private GameObject runePoint7;

    private bool[] runePointValues = { false, false, false, false, false, false, false, false };
    private int[] runePointOrder = { 0, 0, 0, 0, 0, 0, 0, 0 };
    private int order = 0;

    // Start is called before the first frame update
    void Start()
    {

        runePoint0 = this.transform.GetChild(0).gameObject;
        runePoint1 = this.transform.GetChild(1).gameObject;
        runePoint2 = this.transform.GetChild(2).gameObject;
        runePoint3 = this.transform.GetChild(3).gameObject;
        runePoint4 = this.transform.GetChild(4).gameObject;
        runePoint5 = this.transform.GetChild(5).gameObject;
        runePoint6 = this.transform.GetChild(6).gameObject;
        runePoint7 = this.transform.GetChild(7).gameObject;



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggled(int id, bool value)
    {
        runePointValues[id] = value;
        order++;
        runePointOrder[id] = order;

        foreach (bool values in runePointValues)
        {
            Debug.Log("" + values);
        }

        foreach (int ids in runePointOrder)
        {
            Debug.Log("" + ids);
        }
    }
}
