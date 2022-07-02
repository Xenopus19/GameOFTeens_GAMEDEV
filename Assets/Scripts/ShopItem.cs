using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private int price;
    [SerializeField] private Text priceText;
    [SerializeField] private int number;
    public bool isBought;
    private int money;

    private void Start()
    {
        if (isBought)
        {
            PlayerPrefs.SetInt($"IsBought{number}", isBought ? 0 : 1);
        }   

        money = Money.LoadMoney();
        
        if (PlayerPrefs.HasKey($"IsBought{number}"))
        {
            if (PlayerPrefs.GetInt($"IsBought{number}") == 0)
            {
                isBought = true;
            }
            else if (PlayerPrefs.GetInt($"IsBought{number}") == 1)
            {
                isBought = false;
            }          
        }
        else
        {
            isBought = false;
        }

        PlayerPrefs.SetInt($"IsBought{number}", isBought ? 0 : 1);
        Debug.Log(isBought);

        priceText.text = "PRICE: " + price.ToString();
    }

    public void TryBuy()
    {
        if (money >= price)
        {
            Buy();
        }
    }

    private void Buy()
    {
        Money.SpentMoney(price);
        isBought = true;
        PlayerPrefs.SetInt($"IsBought{number}", 0);
        SavingTransport.SaveTransport(number);
    }
}
