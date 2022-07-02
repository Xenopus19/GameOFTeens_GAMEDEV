using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private int price;
    [SerializeField] private int number;
    private int money;

    private void Start()
    {
        money = Money.LoadMoney();
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
        SavingTransport.SaveTransport(number);
        Debug.Log(PlayerPrefs.GetInt("Transport"));
    }
}
