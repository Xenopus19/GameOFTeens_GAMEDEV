using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : HealthUI
{
    private Slider bar;

    void Start()
    {
        bar = GetComponent<Slider>();
        Level.OnBoxAmountChanged += UpdateProgress;
        UpdateProgress(1);
    }

    private void Update()
    {
        UpdateProgress(currentHP / maxHP);
    }

    private void UpdateProgress(float filled)
    {
        bar.value = (filled);
    }
}
