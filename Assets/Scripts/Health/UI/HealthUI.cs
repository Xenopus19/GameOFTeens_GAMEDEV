using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public int currentHP;
    public int maxHP;

    public void UpdateNumbers(int newCurrentHp, int newMaxHp)
    {
        currentHP = newCurrentHp;
        maxHP = newMaxHp;
    }
}
