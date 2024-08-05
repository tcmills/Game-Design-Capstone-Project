using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunePoint : MonoBehaviour
{

    public int runePointId;
    private SpellManager spellManager;
    private Toggle runePoint;

    // Start is called before the first frame update
    void Start()
    {

        spellManager = this.transform.parent.gameObject.GetComponent<SpellManager>();
        runePoint = GetComponent<Toggle>();

        runePoint.onValueChanged.AddListener(delegate
        {
            spellManager.Toggled(runePointId, runePoint.isOn);
            runePoint.enabled = false;
        });

    }


}
