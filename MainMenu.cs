using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject chooseClass;

    public void Play()
    {
        if (PlayerPrefs.HasKey("CurrentClass") == false)
        {
            chooseClass.SetActive(true);
        }
        else
        {
            switch (PlayerPrefs.GetInt("CurrentClass"))
            {
                case 1:
                    SceneManager.LoadScene("Class1");
                    break;
                case 2:
                    SceneManager.LoadScene("Class2");
                    break;
                case 3:
                    SceneManager.LoadScene("Class3");
                    break;
                case 4:
                    SceneManager.LoadScene("Class4");
                    break;
            }
        }
    }

    public void Class1()
    {
        SceneManager.LoadScene("Class1");
        PlayerPrefs.SetInt("CurrentClass", 1);

    }

    public void Class2()
    {
        SceneManager.LoadScene("Class2");
        PlayerPrefs.SetInt("CurrentClass", 2);
    }

    public void Class3()
    {
        SceneManager.LoadScene("Class3");
        PlayerPrefs.SetInt("CurrentClass", 3);

    }

    public void Class4()
    {
        SceneManager.LoadScene("Class4");
        PlayerPrefs.SetInt("CurrentClass", 4);
    }

    public void Exit()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }
}