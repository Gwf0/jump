using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    public static int Coin;
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
        Coin = PlayerPrefs.GetInt("coins", Coin);
    }

    // Update is called once per frame
    void Update()
    {   
        Coin = PlayerPrefs.GetInt("coins");
        text.text = Coin.ToString();
    }

    public static void addCoins() {
        Coin +=2;
        PlayerPrefs.SetInt("coins", Coin);
        if(Coin ==  null) {
            Coin = 0;
        }
    }
}
