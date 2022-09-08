using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public GameObject BuyButton;
    int BuySkin;
    void Start()
    {
        BuySkin = PlayerPrefs.GetInt("BuySkin", 1);
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
    }

    public void BuySkins()
    {
        if(MoneyText.Coin >= 100)
        {
            MoneyText.Coin -= 100;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            BuySkin = 100;
            PlayerPrefs.GetInt("BuySkin", BuySkin);
        }
        
    }
}
