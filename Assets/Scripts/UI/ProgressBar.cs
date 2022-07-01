using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        Level.OnBoxAmountChanged += UpdateProgress;
        UpdateProgress(0);
    }

    private void UpdateProgress(float filled)
    {
        image.fillAmount = (filled);
    }

    private void OnDestroy()
    {
        Level.OnBoxAmountChanged -= UpdateProgress;
    }
}
