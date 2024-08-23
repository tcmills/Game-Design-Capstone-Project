using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;
using UnityEngine.SceneManagement;

public class SpellManager : MonoBehaviour
{

    private GameObject runePoint0;
    private GameObject runePoint1;
    private GameObject runePoint2;
    private GameObject runePoint3;
    private GameObject runePoint4;
    private GameObject runePoint5;
    private GameObject runePoint6;
    private GameObject runePoint7;

    private RunePoint runePoint0Script;
    private RunePoint runePoint1Script;
    private RunePoint runePoint2Script;
    private RunePoint runePoint3Script;
    private RunePoint runePoint4Script;
    private RunePoint runePoint5Script;
    private RunePoint runePoint6Script;
    private RunePoint runePoint7Script;

    private int[] runePointOrder = { 0, 0, 0, 0, 0, 0, 0, 0 };
    private int order = 0;
    private string type = "default";
    private int quota = 1000;

    private Order answerOrder;

    public bool canSubmit = false;
    private int timeLimit = 180;
    private bool gameRunning = true;

    public GameObject orderPromptUI;
    public MoneyTracker tracker;
    public OrderGenerator orderGenerator;
    public GameObject gameOverMenu;
    public GameObject gameOverText;
    public GameObject finalScoreText;
    public PauseManager pauseManager;
    public GameObject quotaUI;
    public GameObject sun;

    private AudioSource audioSource;
    public AudioClip correct;
    public AudioClip incorrect;

    // Start is called before the first frame update
    void Start()
    {

        runePoint0 = transform.GetChild(1).GetChild(0).gameObject;
        runePoint1 = transform.GetChild(1).GetChild(1).gameObject;
        runePoint2 = transform.GetChild(1).GetChild(2).gameObject;
        runePoint3 = transform.GetChild(1).GetChild(3).gameObject;
        runePoint4 = transform.GetChild(1).GetChild(4).gameObject;
        runePoint5 = transform.GetChild(1).GetChild(5).gameObject;
        runePoint6 = transform.GetChild(1).GetChild(6).gameObject;
        runePoint7 = transform.GetChild(1).GetChild(7).gameObject;

        runePoint0Script = runePoint0.GetComponent<RunePoint>();
        runePoint1Script = runePoint1.GetComponent<RunePoint>();
        runePoint2Script = runePoint2.GetComponent<RunePoint>();
        runePoint3Script = runePoint3.GetComponent<RunePoint>();
        runePoint4Script = runePoint4.GetComponent<RunePoint>();
        runePoint5Script = runePoint5.GetComponent<RunePoint>();
        runePoint6Script = runePoint6.GetComponent<RunePoint>();
        runePoint7Script = runePoint7.GetComponent<RunePoint>();

        audioSource = GetComponent<AudioSource>();
        quotaUI.GetComponent<TMP_Text>().text += "" + quota;

        StartCoroutine(TimeLimit());
        StartCoroutine(SunMove());

    }

    public void Update()
    {
        if (Input.GetKeyDown("escape"))// && SceneManager.GetActiveScene().ToString() == "Market")
        {
            pauseManager.TogglePause();
        }
    }


    public void ResetLevel()
    {
        SceneManager.LoadScene("Market");
    }

    private void EndGame()
    {
        

        if (int.Parse(tracker.GetMoney()) >= quota)
        {
            gameOverText.GetComponent<TMP_Text>().text = "You Win";
        }
        else
        {
            gameOverText.GetComponent<TMP_Text>().text = "You Lose";
        }

        finalScoreText.GetComponent<TMP_Text>().text += tracker.GetMoney();
        gameOverMenu.SetActive(true);
        gameRunning = false;
    }

    public void SetAnswer(Order AOrder)
    {
        answerOrder = AOrder;
    }
    
    public void CheckAnswer()
    {

        if (canSubmit && order != 0)
        {
            Order input = new Order() { text = "", type = new string[1] { type }, runeOrder = new int[1][][] { new int[1][] { runePointOrder } } };

            if (input.Equals(answerOrder))
            {
                audioSource.PlayOneShot(correct);
                tracker.AddMoney(100);
            }
            else
            {
                audioSource.PlayOneShot(incorrect);
                tracker.SubMoney(50);
            }

            ClearSpell();

            if (orderPromptUI != null)
            {
                orderPromptUI.SetActive(false);
            }

            canSubmit = false;

        }

        if (orderGenerator.GetOrderSize() == 0 || int.Parse(tracker.GetMoney()) >= quota)
        {
            EndGame();
        }

    }

    IEnumerator TimeLimit()
    {
        yield return new WaitForSeconds(timeLimit);
        EndGame();
    }

    IEnumerator SunMove()
    {
        while (gameRunning)
        {
            yield return new WaitForSeconds(1);
            MoveSun();
        }

    }

    private void MoveSun()
    {
        sun.transform.RotateAround(sun.transform.position, sun.transform.up, 1);
    }

    public void ClearSpell()
    {
        for (int l = 0; l < runePointOrder.Length; l++)
        {
            runePointOrder[l] = 0;
        }
        
        order = 0;

        type = "default";

        runePoint0Script.ResetRunePoint();
        runePoint1Script.ResetRunePoint();
        runePoint2Script.ResetRunePoint();
        runePoint3Script.ResetRunePoint();
        runePoint4Script.ResetRunePoint();
        runePoint5Script.ResetRunePoint();
        runePoint6Script.ResetRunePoint();
        runePoint7Script.ResetRunePoint();

        //Debug.Log("" + runePointValues[0] + runePointValues[1] + runePointValues[2] + runePointValues[3] + runePointValues[4] + runePointValues[5] + runePointValues[6] + runePointValues[7]);
        //Debug.Log("" + runePointOrder[0] + runePointOrder[1] + runePointOrder[2] + runePointOrder[3] + runePointOrder[4] + runePointOrder[5] + runePointOrder[6] + runePointOrder[7]);
        //Debug.Log("\n");
    }

    public void Toggled(int id, bool value)
    {
        order++;
        runePointOrder[id] = order;

        //Debug.Log("" + runePointValues[0] + runePointValues[1] + runePointValues[2] + runePointValues[3] + runePointValues[4] + runePointValues[5] + runePointValues[6] + runePointValues[7]);
        //Debug.Log("" + runePointOrder[0] + runePointOrder[1] + runePointOrder[2] + runePointOrder[3] + runePointOrder[4] + runePointOrder[5] + runePointOrder[6] + runePointOrder[7]);
        //Debug.Log("\n");


        RectTransform point1 = null;
        RectTransform point2 = null;
        GameObject line;
        RectTransform lineRectTransform;

        if (order > 1)
        {

            switch (id)
            {
                case 0:
                    point1 = runePoint0.GetComponent<RectTransform>();
                    break;
                case 1:
                    point1 = runePoint1.GetComponent<RectTransform>();
                    break;
                case 2:
                    point1 = runePoint2.GetComponent<RectTransform>();
                    break;
                case 3:
                    point1 = runePoint3.GetComponent<RectTransform>();
                    break;
                case 4:
                    point1 = runePoint4.GetComponent<RectTransform>();
                    break;
                case 5:
                    point1 = runePoint5.GetComponent<RectTransform>();
                    break;
                case 6:
                    point1 = runePoint6.GetComponent<RectTransform>();
                    break;
                case 7:
                    point1 = runePoint7.GetComponent<RectTransform>();
                    break;
            }

            for (int i = 0; i < runePointOrder.Length; i++)
            {
                if (runePointOrder[i] == order-1)
                {
                    switch (i)
                    {
                        case 0:
                            point2 = runePoint0.GetComponent<RectTransform>();
                            break;
                        case 1:
                            point2 = runePoint1.GetComponent<RectTransform>();
                            break;
                        case 2:
                            point2 = runePoint2.GetComponent<RectTransform>();
                            break;
                        case 3:
                            point2 = runePoint3.GetComponent<RectTransform>();
                            break;
                        case 4:
                            point2 = runePoint4.GetComponent<RectTransform>();
                            break;
                        case 5:
                            point2 = runePoint5.GetComponent<RectTransform>();
                            break;
                        case 6:
                            point2 = runePoint6.GetComponent<RectTransform>();
                            break;
                        case 7:
                            point2 = runePoint7.GetComponent<RectTransform>();
                            break;
                    }
                    break;
                }
            }

            if (point1 != null && point2 != null)
            {
                line = point1.GetComponent<RunePoint>().line;
                lineRectTransform = line.GetComponent<RectTransform>();

                lineRectTransform.localPosition = (point1.localPosition + point2.localPosition) / 2;
                Vector3 difference = point1.localPosition - point2.localPosition;
                lineRectTransform.sizeDelta = new Vector3(difference.magnitude, 10);
                lineRectTransform.rotation = Quaternion.Euler(new Vector3(0, 0, (Mathf.Atan(difference.y / difference.x) * 180) / Mathf.PI));
                line.SetActive(true);
            }

        }
    }

    public void changeSpellType(string spellType)
    {
        if (spellType == "fire")
        {
            type = "fire";
            runePoint0Script.changeColor("red");
            runePoint1Script.changeColor("red");
            runePoint2Script.changeColor("red");
            runePoint3Script.changeColor("red");
            runePoint4Script.changeColor("red");
            runePoint5Script.changeColor("red");
            runePoint6Script.changeColor("red");
            runePoint7Script.changeColor("red");

        } else if (spellType == "water")
        {
            type = "water";
            runePoint0Script.changeColor("blue");
            runePoint1Script.changeColor("blue");
            runePoint2Script.changeColor("blue");
            runePoint3Script.changeColor("blue");
            runePoint4Script.changeColor("blue");
            runePoint5Script.changeColor("blue");
            runePoint6Script.changeColor("blue");
            runePoint7Script.changeColor("blue");

        } else if (spellType == "nature")
        {
            type = "nature";
            runePoint0Script.changeColor("green");
            runePoint1Script.changeColor("green");
            runePoint2Script.changeColor("green");
            runePoint3Script.changeColor("green");
            runePoint4Script.changeColor("green");
            runePoint5Script.changeColor("green");
            runePoint6Script.changeColor("green");
            runePoint7Script.changeColor("green");

        } else if (spellType == "air")
        {
            type = "air";
            runePoint0Script.changeColor("pink");
            runePoint1Script.changeColor("pink");
            runePoint2Script.changeColor("pink");
            runePoint3Script.changeColor("pink");
            runePoint4Script.changeColor("pink");
            runePoint5Script.changeColor("pink");
            runePoint6Script.changeColor("pink");
            runePoint7Script.changeColor("pink");

        } else
        {
            runePoint0Script.changeColor("");
            runePoint1Script.changeColor("");
            runePoint2Script.changeColor("");
            runePoint3Script.changeColor("");
            runePoint4Script.changeColor("");
            runePoint5Script.changeColor("");
            runePoint6Script.changeColor("");
            runePoint7Script.changeColor("");
        }
    }

}
