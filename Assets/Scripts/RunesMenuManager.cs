using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunesMenuManager : MonoBehaviour
{

    public Button left;
    public Button right;

    public GameObject page0;
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    public GameObject page6;
    public GameObject page7;
    public GameObject page8;
    public GameObject page9;
    public GameObject page10;
    public GameObject page11;

    private int pageId = 0;

    public void OpenMenu()
    {
        gameObject.SetActive(true);
    }

    public void CloseMenu()
    {
        gameObject.SetActive(false);
    }

    public void PageRight()
    {
        GetPage(pageId).SetActive(false);
        if (pageId == 0)
        {
            left.gameObject.SetActive(true);
        }
        pageId++;
        GetPage(pageId).SetActive(true);
        if (pageId == 11)
        {
            right.gameObject.SetActive(false);
        }
    }

    public void PageLeft()
    {
        GetPage(pageId).SetActive(false);
        if (pageId == 11)
        {
            right.gameObject.SetActive(true);
        }
        pageId--;
        GetPage(pageId).SetActive(true);
        if (pageId == 0)
        {
            left.gameObject.SetActive(false);
        }
    }

    private GameObject GetPage(int id)
    {
        switch (id)
        {
            case 0:
                return page0;
            case 1:
                return page1;
            case 2:
                return page2;
            case 3:
                return page3;
            case 4:
                return page4;
            case 5:
                return page5;
            case 6:
                return page6;
            case 7:
                return page7;
            case 8:
                return page8;
            case 9:
                return page9;
            case 10:
                return page10;
            case 11:
                return page11;
        }

        return page0;
    }
}
