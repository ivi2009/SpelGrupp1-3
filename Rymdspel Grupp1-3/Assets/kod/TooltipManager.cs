using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TooltipManager : MonoBehaviour
{
    RectTransform rectTransform;
    public TextMeshProUGUI tip;
    public static string tooltipString = "";


    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        tooltipString = ""; //nollar tooltipen
    }

    void Update()
    {
        tip.text = tooltipString; //skriv skit
        rectTransform.position = Mouse.current.position.ReadValue(); //gå till mus pos
    }
}

