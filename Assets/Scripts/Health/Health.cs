using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHP;
    public int maxHP;
    public GameObject thisHealthUI;
    private HealthUI UI;

    private void Start()
    {
        currentHP = maxHP;
        UI = thisHealthUI.GetComponent<HealthUI>();
        UI.UpdateNumbers(currentHP, maxHP);
    }

    public void AddHP(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP) currentHP = maxHP;
        UI.UpdateNumbers(currentHP, maxHP);
    }

    public void RemoveHP(int amount)
    {
        currentHP -= amount;
        UI.UpdateNumbers(currentHP, maxHP);
        //if (currentHP <= 0) ;
    }
}
