using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearSpell : MonoBehaviour
{

    public SpellManager spellManager;
    private Button clearSpell;

    // Start is called before the first frame update
    void Start()
    {
        if (spellManager != null)
        {
            
            clearSpell = GetComponent<Button>();

            clearSpell.onClick.AddListener(delegate
            {
                spellManager.ClearSpell();
            });
        }
        
    }
}
