using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance;
    public Text moneyText;
    int money;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Update()
    {
        money = PlayerPrefs.GetInt("Money");
        moneyText.text = money.ToString();

    }

    public void earnMoney()
    {
        money++;
        PlayerPrefs.SetInt("Money", money);
    }

    public int returnMoney()
    {
        return money;
    }

}