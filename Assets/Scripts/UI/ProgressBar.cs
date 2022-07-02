using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider bar;

    void Start()
    {
        bar = GetComponent<Slider>();
        Level.OnBoxAmountChanged += UpdateProgress;
        UpdateProgress(0);
    }

    private void UpdateProgress(float filled)
    {
        bar.value = (filled);
    }

    private void OnDestroy()
    {
        Level.OnBoxAmountChanged -= UpdateProgress;
    }
}
