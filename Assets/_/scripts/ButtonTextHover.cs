
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ButtonTextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Text")]
    public TMP_Text buttonText;

    [Header("Colors")]
    public Color normalColor = Color.black;
    public Color hoverColor = Color.white;

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.color = normalColor;
    }
}
