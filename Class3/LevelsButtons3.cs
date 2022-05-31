using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsButtons3 : MonoBehaviour
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
            if (answer == "корнем")
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
            if (answer == "миллиметр,сантиметр,дециметр,метр")
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
            if (answer == "99")
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
            if (answer == "500")
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
            if (answer == "6")
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
            if (answer == "256" | answer == "265" | answer == "526" | answer == "562" | answer == "625" | answer == "652")
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
            if (answer == "548")
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
            if (answer == "8")
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
            if (answer == "нет" | answer == "неверно")
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
            if (answer == "231")
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
                PlayerPrefs.SetInt("3Class" + currentLevel, 1);
                MoneyManager.Instance.earnMoney();
                PlayerPrefs.SetInt("CurrentClass", 3);
                if (lvl == 12)
                    isItTwelveLevel = true;
                else isItTwelveLevel = false;
                break;
            default:
                PlayerPrefs.SetInt("3Class" + 1, 0);
                isItTwelveLevel = false;
                break;
        }

    }
}