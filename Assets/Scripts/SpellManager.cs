using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

        runePoint0 = this.transform.GetChild(1).GetChild(0).gameObject;
        runePoint1 = this.transform.GetChild(1).GetChild(1).gameObject;
        runePoint2 = this.transform.GetChild(1).GetChild(2).gameObject;
        runePoint3 = this.transform.GetChild(1).GetChild(3).gameObject;
        runePoint4 = this.transform.GetChild(1).GetChild(4).gameObject;
        runePoint5 = this.transform.GetChild(1).GetChild(5).gameObject;
        runePoint6 = this.transform.GetChild(1).GetChild(6).gameObject;
        runePoint7 = this.transform.GetChild(1).GetChild(7).gameObject;



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

        //foreach (bool values in runePointValues)
        //{
        //    Debug.Log("" + values);
        //}

        //foreach (int ids in runePointOrder)
        //{
        //    Debug.Log("" + ids);
        //}


        RectTransform point1 = null;
        RectTransform point2 = null;
        GameObject line;
        RectTransform lineRectTransform;

        if (order > 1)
        {

            switch (id)
            {
                case 0:
                    point1 = runePoint0.GetComponent<RectTransform>();
                    break;
                case 1:
                    point1 = runePoint1.GetComponent<RectTransform>();
                    break;
                case 2:
                    point1 = runePoint2.GetComponent<RectTransform>();
                    break;
                case 3:
                    point1 = runePoint3.GetComponent<RectTransform>();
                    break;
                case 4:
                    point1 = runePoint4.GetComponent<RectTransform>();
                    break;
                case 5:
                    point1 = runePoint5.GetComponent<RectTransform>();
                    break;
                case 6:
                    point1 = runePoint6.GetComponent<RectTransform>();
                    break;
                case 7:
                    point1 = runePoint7.GetComponent<RectTransform>();
                    break;
            }

            for (int i = 0; i < runePointOrder.Length;i++)
            {
                if (runePointOrder[i] == order-1)
                {
                    switch (i)
                    {
                        case 0:
                            point2 = runePoint0.GetComponent<RectTransform>();
                            break;
                        case 1:
                            point2 = runePoint1.GetComponent<RectTransform>();
                            break;
                        case 2:
                            point2 = runePoint2.GetComponent<RectTransform>();
                            break;
                        case 3:
                            point2 = runePoint3.GetComponent<RectTransform>();
                            break;
                        case 4:
                            point2 = runePoint4.GetComponent<RectTransform>();
                            break;
                        case 5:
                            point2 = runePoint5.GetComponent<RectTransform>();
                            break;
                        case 6:
                            point2 = runePoint6.GetComponent<RectTransform>();
                            break;
                        case 7:
                            point2 = runePoint7.GetComponent<RectTransform>();
                            break;
                    }
                    break;
                }
            }

            if (point1 != null && point2 != null)
            {
                line = point1.GetComponent<RunePoint>().line;
                lineRectTransform = line.GetComponent<RectTransform>();

                lineRectTransform.localPosition = (point1.localPosition + point2.localPosition) / 2;
                Vector3 diffVector = point1.localPosition - point2.localPosition;
                lineRectTransform.sizeDelta = new Vector3(diffVector.magnitude, 10);
                lineRectTransform.rotation = Quaternion.Euler(new Vector3(0, 0, 180 * Mathf.Atan(diffVector.y / diffVector.x) / Mathf.PI));
                line.SetActive(true);
            }

        }
    }
}
