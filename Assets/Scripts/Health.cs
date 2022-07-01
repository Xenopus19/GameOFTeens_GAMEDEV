using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int currentHP;
    private int maxHP;
    public Health(int maxiHP)
    {
        currentHP = maxiHP;
        maxHP = maxiHP;
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
