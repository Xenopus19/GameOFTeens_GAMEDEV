using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : HealthUI
{
    private Slider bar;
    private Health health;

    void Start()
    {
        bar = GetComponent<Slider>();
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        health.OnHPChanged += UpdateProgress;
        UpdateProgress(1);
    }

    private void UpdateProgress(float filled)
    {
        bar.value = (filled);
    }

    private void OnDestroy()
    {
        health.OnHPChanged -= UpdateProgress;
    }
}
