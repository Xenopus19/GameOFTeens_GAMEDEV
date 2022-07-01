using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Color defaultColor;
    public Color pressedColor;

    private void Start()
    {
        defaultColor = gameObject.GetComponent<Image>().color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.GetComponent<Image>().color = pressedColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        gameObject.GetComponent<Image>().color = defaultColor;
    }

    public void OnDisable()
    {
        gameObject.GetComponent<Image>().color = defaultColor;
    }
}
