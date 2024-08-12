using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishSpell : MonoBehaviour
{
    public SpellManager spellManager;
    private Button finishSpell;

    // Start is called before the first frame update
    void Start()
    {
        if (spellManager != null)
        {

            finishSpell = GetComponent<Button>();

            finishSpell.onClick.AddListener(delegate
            {
                spellManager.CheckAnswer();
            });
        }

    }
}
