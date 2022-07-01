using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHP;
    public int maxHP;

    private void Start()
    {
        currentHP = maxHP;
    }

    public void AddHP(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP) currentHP = maxHP;
    }

    public void RemoveHP(int amount)
    {
        currentHP -= amount;
        //if (currentHP <= 0) ;
    }
}
