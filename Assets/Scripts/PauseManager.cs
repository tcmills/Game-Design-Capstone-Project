using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{

    public static bool IsPaused { get; set; } = false;
    public AudioSource audioSource;
    public AudioClip clip1;
    public AudioClip clip2;

    public void TogglePause()
    {
        IsPaused = !IsPaused;
        if (IsPaused)
        {
            audioSource.PlayOneShot(clip1);
        }
        else
        {
            audioSource.PlayOneShot(clip2);
        }
        HandlePauseChange();
    }

    public void Pause()
    {
        audioSource.PlayOneShot(clip1);
        IsPaused = true;
        HandlePauseChange();
    }

    public void UnPause()
    {
        audioSource.PlayOneShot(clip2);
        IsPaused = false;
        HandlePauseChange();
    }

    private void HandlePauseChange()
    {
        this.gameObject.SetActive(IsPaused);
        Time.timeScale = IsPaused ? 0 : 1;
    }

}
