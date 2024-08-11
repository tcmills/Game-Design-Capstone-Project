using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunePoint : MonoBehaviour
{

    public int runePointId;
    public GameObject line;
    private SpellManager spellManager;
    private Toggle runePoint;

    // Start is called before the first frame update
    void Start()
    {

        spellManager = transform.parent.parent.gameObject.GetComponent<SpellManager>();
        runePoint = GetComponent<Toggle>();

        runePoint.onValueChanged.AddListener(delegate
        {
            if (runePoint.isOn == true)
            {
                spellManager.Toggled(runePointId, runePoint.isOn);
                runePoint.enabled = false;
            }
        });

    }

    public void ResetRunePoint()
    {
        if (runePoint != null)
        {
            runePoint.enabled = true;
            runePoint.isOn = false;
            line.SetActive(false);
            changeColor("");
        }
    }

    public void changeColor(string color)
    {
        if (color == "red") {

            line.GetComponent<Image>().color = new Color32(233, 58, 56, 255);

        } else if (color == "blue")
        {

            line.GetComponent<Image>().color = new Color32(54, 73, 222, 255);

        } else if (color == "green")
        {

            line.GetComponent<Image>().color = new Color32(95, 207, 56, 255);

        } else if (color == "pink")
        {

            line.GetComponent<Image>().color = new Color32(190, 127, 219, 255);

        } else {

            line.GetComponent<Image>().color = new Color32(207, 77, 204, 255);

        }
    }

}
