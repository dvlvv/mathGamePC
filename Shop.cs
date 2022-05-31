using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    public int charNum; // номер персонажа от 0 до 3
    public Button buyButton; // кнопка покупки
    public int price; // цена

    public Sprite purch; // спрайт кнопки купить
    public Sprite selected; // спрайт кнопки выбрано
    public Sprite select; // спрайт кнопки выбрать


    public Image[] chars; // массив доступных персонажей

    private void Start()
    {
        if (PlayerPrefs.GetInt("Gray" + "buy") == 0) // обработка первого захода в игру
        {
            foreach (Image i in chars) // для каждого персонажа
            {
                if ("Gray" == i.name) // для первого
                {
                    PlayerPrefs.SetInt("Gray" + "buy", 1); // купить первого персонажа
                    PlayerPrefs.SetInt("Gray" + "select", 1); // выбрать первого персонажа
                }
                else
                {
                    PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 0); // остальне персонажи не куплены
                }
            }
        }
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        { 
            buyButton.GetComponent<Image>().sprite = purch;
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            if (PlayerPrefs.GetInt(GetComponent<Image>().name + "select") == 1)
            {
                buyButton.GetComponent<Image>().sprite = selected;
            }
            else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "select") == 0)
            {
                buyButton.GetComponent<Image>().sprite = select;
            }
        }
    }

    public void buy()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0) // если персонаж не куплен
        {
            if (MoneyManager.Instance.returnMoney() >= price) //  если хватает средств
            {
                buyButton.GetComponent<Image>().sprite = selected; // выбать купленого персонажа
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - price); // вчетание ценны из средств
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1); // персонаж куплен
                PlayerPrefs.SetInt("characater", charNum); //  персонаж выбран как игровой

                foreach (Image i in chars) //  цикл измененияя кнопки
                {
                    if (GetComponent<Image>().name == i.name) //  если персонаж только что куплен
                    {
                        PlayerPrefs.SetInt(GetComponent<Image>().name + "select", 1); // персонаж выбран игровым
                    }
                    else
                    {
                        PlayerPrefs.SetInt(i.name + "select", 0); //  а все остальные нет
                    }
                }
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1) // если персонаж приобретен
        {
            buyButton.GetComponent<Image>().sprite = selected; // активировать кнопку выбрано
            PlayerPrefs.SetInt(GetComponent<Image>().name + "select", 1); // записать персонажа как выбранного
            PlayerPrefs.SetInt("characater", charNum); // персонаж выбран как игровой 

            foreach (Image i in chars) // цикл измененияя кнопки
            {
                if (GetComponent<Image>().name == i.name) // если персонаж только что куплен
                {
                    PlayerPrefs.SetInt(GetComponent<Image>().name + "select", 1); // персонаж выбран игровым
                }
                else
                {
                    PlayerPrefs.SetInt(i.name + "select", 0);  // а все остальные нет
                }
            }
        }
    }
}
