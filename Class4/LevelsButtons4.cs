using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsButtons4 : MonoBehaviour
{
    public int currentLevel;
    public static bool isItTwelveLevel;

    public InputField playersAnswer;
    public GameObject correctAnswer;
    public GameObject uncorrectAnswer;
    public GameObject levelMenu;
    private string toLowerAnswer;
    private string answer;

    public void inputedAnswer()
    {
        toLowerAnswer = playersAnswer.text.ToLower();
        answer = toLowerAnswer.Replace(" ", string.Empty);
        if (currentLevel == 1)
        {
            if (answer == "скорость")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }
        else if (currentLevel == 2)
        {
            if (answer == "180")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

        else if (currentLevel == 3)
        {
            if (answer == "2176")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

        else if (currentLevel == 4)
        {
            if (answer == "4")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

        else if (currentLevel == 5)
        {
            if (answer == "2760-392")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

        else if (currentLevel == 6)
        {
            if (answer == "3")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

        else if (currentLevel == 7)
        {
            if (answer == "б")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

        else if (currentLevel == 8)
        {
            if (answer == "1/85/83/52/3")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

        else if (currentLevel == 9)
        {
            if (answer == "72")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

        else if (currentLevel == 10)
        {
            if (answer == "90")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

        else if (currentLevel == 11)
        {
            if (answer != "")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

        else
        {
            if (answer != "")
            {
                ToTheNextLevel();
            }
            else
            {
                uncorrectAnswer.SetActive(true);
            }
        }

    }

    public void ToTheNextLevel()
    {
        levelMenu.SetActive(false);
        correctAnswer.SetActive(true);

        switch (currentLevel)
        {
            case int lvl when lvl > 0:
                PlayerPrefs.SetInt("4Class" + currentLevel, 1);
                MoneyManager.Instance.earnMoney();
                PlayerPrefs.SetInt("CurrentClass", 4);
                if (lvl == 12)
                    isItTwelveLevel = true;
                else isItTwelveLevel = false;
                break;
            default:
                PlayerPrefs.SetInt("4Class" + 1, 0);
                isItTwelveLevel = false;
                break;
        }

    }
}