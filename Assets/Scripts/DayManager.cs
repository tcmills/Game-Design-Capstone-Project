using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayManager : MonoBehaviour
{

    public static int day = 1;

    //private void Awake()
    //{
    //    DontDestroyOnLoad(this);
    //}

    public void nextDay()
    {
        day++;
        if (day > 3)
        {
            day = 3;
        }
        SceneManager.LoadScene("Market");
    }

    public void setDay(int set)
    {
        day = set;
        if (day != 1 && day != 2 && day != 3)
        {
            day = 3;
        }
    }

}
