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

        UpdateButtons();
    }
    private void UpdateButtons()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            if (shopItems[i].isBought)
            {
                buttons[i].gameObject.SetActive(false);
            }
        }
    }

    public void Switch(int direction)
    {
        int newIndex = currentIndex + direction;

        if (newIndex >= shopItems.Length || newIndex < 0) return;

        CloseAll();

        shopItems[newIndex].gameObject.SetActive(true);

        if (!shopItems[newIndex].isBought)
            buttons[newIndex].gameObject.SetActive(true);

        if (shopItems[newIndex])
            SavingTransport.SaveTransport(newIndex);

        currentIndex += direction;
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
