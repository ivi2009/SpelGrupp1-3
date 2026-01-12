using TMPro;
using UnityEngine;

public class Timeleft : MonoBehaviour
{
    public TextMeshProUGUI timeLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeLeft.text = "Time Left: " + GameStuff.timer;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
