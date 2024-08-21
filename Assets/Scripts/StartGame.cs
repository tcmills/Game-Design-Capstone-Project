using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public void LoadLevel()
    {
        SceneManager.LoadScene("Market");
    }

    public void LoadTitle()
    {
        if (PauseManager.IsPaused)
        {
            PauseManager.IsPaused = false;
            Time.timeScale = 1;
        }
        SceneManager.LoadScene("Title");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
            Application.OpenURL(webplayerQuitURL);
        #else
            Application.Quit();
        #endif
    }

}
