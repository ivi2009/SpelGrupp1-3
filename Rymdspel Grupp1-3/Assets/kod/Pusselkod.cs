using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pusselkod : MonoBehaviour
{
    public TMP_InputField codeInput;
    public static List<string> codes = new List<string>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        codes.Clear();
        codes.AddRange(new List<string>
        {
            "12345",
            "moves",
            "00000"
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IsCodeCorect(int puzzleID)
    {
        if (codeInput.text.ToLower() == codes[puzzleID])
        {
            Debug.Log("rätt");
            gameObject.SetActive(false);
            if (puzzleID == 0) GameStuff.puzzle0Done = true;
            if (puzzleID == 1) GameStuff.puzzle1Done = true;
            if (puzzleID == 2) GameStuff.puzzle2Done = true;
        }
        else
        {
            Debug.Log("fel");
            GameStuff.timer -= 30f;
        }
        //är koden korekt?
    }

    public void CloseCanvas()
    {
        gameObject.SetActive(false);
    }
}
