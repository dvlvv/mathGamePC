using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite def;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public GameObject cat;

    void Start()
    {
        switch (PlayerPrefs.GetInt("characater"))
        {
            case 1:
                cat.GetComponent<SpriteRenderer>().sprite = one;
                break;
            case 2:
                cat.GetComponent<SpriteRenderer>().sprite = two;
                break;
            case 3:
                cat.GetComponent<SpriteRenderer>().sprite = three;
                break;
            default:
                cat.GetComponent<SpriteRenderer>().sprite = def;
                break;
        }  
    }
}
