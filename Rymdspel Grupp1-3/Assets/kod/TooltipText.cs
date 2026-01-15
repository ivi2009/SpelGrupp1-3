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
        TooltipManager.tooltipString = displayText; //om musen hovrar över kapp, skriv sak
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TooltipManager.tooltipString = ""; //om musen inte hovrar över kanpp, sluta
    }
}
