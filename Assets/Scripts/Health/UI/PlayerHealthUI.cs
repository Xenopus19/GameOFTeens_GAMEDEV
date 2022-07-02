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
        Health.OnHPChanged += UpdateProgress;
        UpdateProgress(1);
    }

    private void UpdateProgress(float filled)
    {
        bar.value = (filled);
    }

    private void OnDestroy()
    {
        Health.OnHPChanged -= UpdateProgress;
    }
}
