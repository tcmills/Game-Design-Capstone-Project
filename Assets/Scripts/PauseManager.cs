using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{

    public static bool IsPaused { get; private set; } = false;

    public void TogglePause()
    {
        IsPaused = !IsPaused;
        HandlePauseChange();
    }

    public void Pause()
    {
        IsPaused = true;
        HandlePauseChange();
    }

    public void UnPause()
    {
        IsPaused = false;
        HandlePauseChange();
    }

    private void HandlePauseChange()
    {
        this.gameObject.SetActive(IsPaused);
        Time.timeScale = IsPaused ? 0 : 1;
    }

}
