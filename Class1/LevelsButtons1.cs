using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsButtons1 : MonoBehaviour
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
            if (answer == "+-=" | answer == "+=-" | answer == "-+=" | answer == "-=+" | answer == "=+-" | answer == "=-+")
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
            if (answer == "12" | answer == "21")
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
            if (answer == "1+4=5")
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
            if (answer == "квадрат")
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
            if (answer == "-=")
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
            if (answer == "многоугольники" | answer == "многоугольник")
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
            if (answer == "в")
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
            if (answer == "3")
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
            if (answer == "7-2=5")
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
            if (answer == "зелёного" | answer == "зеленого" | answer == "зеленый" | answer == "зелёный")
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
                PlayerPrefs.SetInt("1Class" + currentLevel, 1);
                MoneyManager.Instance.earnMoney();
                PlayerPrefs.SetInt("CurrentClass", 1);
                if (lvl == 12)
                    isItTwelveLevel = true;
                else isItTwelveLevel = false;
                break;
            default:
                PlayerPrefs.SetInt("1Class" + 1, 0);
                isItTwelveLevel = false;
                break;
        }
        
    }
}
