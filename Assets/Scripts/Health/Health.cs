using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public AudioSource GotDamageAudio;
    public float currentHP;
    public float maxHP;

    public Action<float> OnHPChanged;

    private void Start()
    {
        currentHP = maxHP;
        UpdateHP();
    }

    public void AddHP(float amount)
    {
        currentHP += amount;
        if (currentHP > maxHP) currentHP = maxHP;
        UpdateHP();
    }

    public void RemoveHP(float amount)
    {
        currentHP -= amount;
        if(GotDamageAudio != null) GotDamageAudio.Play();
        UpdateHP();
        //if (currentHP <= 0) ;
    }

    private void UpdateHP()
    { 
        OnHPChanged?.Invoke(currentHP / maxHP);
    }
}
