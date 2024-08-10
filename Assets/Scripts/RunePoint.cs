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
        }
    }


}
