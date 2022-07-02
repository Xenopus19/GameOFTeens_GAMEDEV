using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHP;
    public int maxHP;
    [SerializeField] private GameObject thisHealthUI;
    private HealthUI UI;

    private void Start()
    {
        currentHP = maxHP;
        UI = UI.GetComponent<HealthUI>();
        UpdateUIHP();
        UI.maxHP = maxHP;
    }

    public void AddHP(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP) currentHP = maxHP;
        UpdateUIHP();
    }

    public void RemoveHP(int amount)
    {
        currentHP -= amount;
        UpdateUIHP();
        //if (currentHP <= 0) ;
    }

    private void UpdateUIHP()
    {
        UI.currentHP = currentHP;
    }
}
