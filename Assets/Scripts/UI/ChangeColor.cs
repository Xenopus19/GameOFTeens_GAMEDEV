using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Color defaultColor;
    private Image image;
    public Color pressedColor;

    private void Start()
    {
        image = GetComponent<Image>();
        defaultColor = image.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = pressedColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = defaultColor;
    }

    public void OnDisable()
    {
        image.color = defaultColor;
    }
}
