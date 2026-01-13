using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string displayText;

    void Start()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        TooltipManager.tooltipString = displayText;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TooltipManager.tooltipString = "";
    }
}
