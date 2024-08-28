using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{

    private AudioSource audioSource;
    public SpellManager spellManager;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseManager.IsPaused || !spellManager.gameRunning)
        {
            audioSource.volume = 0.5f;
        } else
        {
            audioSource.volume = 1.0f;
        }
    }
}
