using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHP;
    public int maxHP;

    public static Action<float> OnHPChanged;

    private void Start()
    {
        currentHP = maxHP;
        UpdateHP();
    }

    public void AddHP(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP) currentHP = maxHP;
        UpdateHP();
    }

    public void RemoveHP(int amount)
    {
        currentHP -= amount;
        UpdateHP();
        //if (currentHP <= 0) ;
    }

    private void UpdateHP()
    {
        OnHPChanged?.Invoke(currentHP / maxHP);
    }
}
