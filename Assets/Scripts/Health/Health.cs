using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public AudioSource GotDamageAudio;
    public float currentHP;
    public float maxHP;

    public Action<float> OnHPChanged;
    public Action OnDie;

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
        if (currentHP <= 0) 
            Die();
    }

    private void Die()
    {
        gameObject.GetComponent<IDieable>().Die();
    }

    private void UpdateHP()
    { 
        OnHPChanged?.Invoke(currentHP / maxHP);
    }
}

public interface IDieable
{
    void Die();
}
