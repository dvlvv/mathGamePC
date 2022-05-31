using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelsManager3 : MonoBehaviour
{
    [SerializeField] private bool unlocked;

    public Image lockImage;
    public Sprite lockedSprite;
    public Sprite unlockedSprite;
    public Button levelButton;
    public int currentLevel;

    private void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Update()
    {
        UpdateLevelImage();
        UpdateLevelStatus();
    }


    private void UpdateLevelImage()
    {
        switch (unlocked) 
        {

            case true:  
                lockImage.GetComponent<Image>().sprite = unlockedSprite;
                levelButton.interactable = true;
                if (PlayerPrefs.GetInt("3Class" + currentLevel) == 1)
                {
                    lockImage.gameObject.SetActive(false);
                }
                break;
            case false: 
                lockImage.GetComponent<Image>().sprite = lockedSprite;
                levelButton.interactable = false;
                break;
        }
    }

    private void UpdateLevelStatus()
    {
        int prevLevel = int.Parse(gameObject.name) - 1;
        if (PlayerPrefs.GetInt("3Class" + prevLevel.ToString()) == 1)
        {
            unlocked = true;
        }

    }
}
