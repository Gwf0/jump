using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public GameObject BuyButton, BuyButton2, BuyButton3;
    int BuySkin, BuySkin2, BuySkin3;
    void Start()
    {
        BuySkin = PlayerPrefs.GetInt("BuySkin", 1);
        BuySkin2 = PlayerPrefs.GetInt("BuySkin2", 2);
        BuySkin3 = PlayerPrefs.GetInt("BuySkin3", 3);

    }

    // Update is called once per frame
    void Update()
    {
        if (BuySkin == 1)
        {
            BuyButton.SetActive(true);
        }
        else
        {
            BuyButton.SetActive(false);
        }

        if (BuySkin2 == 2)
        {
            BuyButton2.SetActive(true);
        }
        else
        {
            BuyButton2.SetActive(false);
        }
        
        if (BuySkin3 == 3)
        {
            BuyButton3.SetActive(true);
        }
        else
        {
            BuyButton3.SetActive(false);
        }
    }

    public void BuySkins()
    {
        if(MoneyText.Coin >= 5)
        {
            MoneyText.Coin -= 5;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            BuySkin = 5;
            PlayerPrefs.GetInt("BuySkin", BuySkin);
        }    
        if(MoneyText.Coin >= 3)
        {
            MoneyText.Coin -= 3;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            BuySkin2 = 3;
            PlayerPrefs.GetInt("BuySkin2", BuySkin2);
        }
        if(MoneyText.Coin >= 2)
        {
            MoneyText.Coin -= 2;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            BuySkin3 = 2;
            PlayerPrefs.GetInt("BuySkin3", BuySkin3);
        }  
    }
}
