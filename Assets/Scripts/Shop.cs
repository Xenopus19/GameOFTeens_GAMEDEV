using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private ShopItem[] shopItems;
    [SerializeField] private Button[] buttons;
    [SerializeField] private Text moneyText;
    private int currentIndex;

    private void Start()
    {
        currentIndex = SavingTransport.TransportIndex;
        buttons[currentIndex].gameObject.SetActive(true);
        moneyText.text = Money.LoadMoney().ToString();
       
    }

    private void Update()
    {
        moneyText.text = Money.LoadMoney().ToString();
        if (Input.GetKeyDown(KeyCode.A))
        {
            Money.IncreaseMoney(100000);
        }

        for (int i = 0; i < shopItems.Length; i++)
        {
            if (shopItems[i].isBought)
            {
                buttons[i].gameObject.SetActive(false);
            }
        }
    }

    public void Next()
    {
        if (currentIndex + 1 >= shopItems.Length) return;

        CloseAll();

        shopItems[currentIndex + 1].gameObject.SetActive(true);

        if(!shopItems[currentIndex + 1].isBought) buttons[currentIndex + 1].gameObject.SetActive(true);

        if (shopItems[currentIndex + 1].isBought) SavingTransport.SaveTransport(currentIndex + 1);
        currentIndex += 1;    
    }

    public void Previous()
    {
        if (currentIndex - 1 < 0) return;
        CloseAll();

        shopItems[currentIndex - 1].gameObject.SetActive(true);

        if (!shopItems[currentIndex - 1].isBought) buttons[currentIndex - 1].gameObject.SetActive(true);

        if (shopItems[currentIndex - 1].isBought) SavingTransport.SaveTransport(currentIndex - 1);

        currentIndex -= 1;  
    }

    private void CloseAll()
    {
        foreach (ShopItem shopItem in shopItems)
        {
            shopItem.gameObject.SetActive(false);
        }

        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        CloseAll();
        shopItems[PlayerPrefs.GetInt("Transport")].gameObject.SetActive(true);
    }
}
