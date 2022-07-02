using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCanvasOnFinish : MonoBehaviour
{
    [SerializeField] private GameObject FinishCanvas;
    [SerializeField] private GameObject GameCanvas;
    private void Start()
    {
        Level.OnLevelFinished += ToggleCanvas;
    }

    private void ToggleCanvas()
    {
        FinishCanvas.SetActive(GameCanvas.activeInHierarchy);
        GameCanvas.SetActive(!FinishCanvas.activeInHierarchy);
    }

    private void OnDestroy()
    {
        Level.OnLevelFinished -= ToggleCanvas;
    }
}
