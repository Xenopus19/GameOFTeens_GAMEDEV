using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider bar;

    void Start()
    {
        bar = GetComponent<Slider>();
        bar.value = 0;
    }

    private void Update()
    {
        Level.time += Time.deltaTime;
        UpdateProgress();
    }

    private void UpdateProgress()
    {
        bar.value = Level.time / Level.levelTime;
    }
}
