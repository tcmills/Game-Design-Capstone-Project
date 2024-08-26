using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayManager : MonoBehaviour
{

    public static int day = 1;
    public TMP_Text dayText;

    private void Start()
    {
        dayText.text = "Day " + day;
    }

    public void nextDay()
    {
        day++;
        if (day > 3)
        {
            day = 3;
        }
        SceneManager.LoadScene("Market");
    }

}
