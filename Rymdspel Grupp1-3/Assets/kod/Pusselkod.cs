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
            "shine",
            "moves",
            "judge",
            "plant"
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IsCodeCorect(int puzzleID)
    {
        if (codeInput.text.ToLower() == codes[puzzleID])  //är koden korekt?
        {
            gameObject.SetActive(false);
            if (puzzleID == 0) GameStuff.puzzle0Done = true;
            if (puzzleID == 1) GameStuff.puzzle1Done = true;
            if (puzzleID == 2) GameStuff.puzzle2Done = true;
            if (puzzleID == 3) GameStuff.puzzle3Done = true;
            GameStuff.correctFlash = true;
        }
        else
        {
            GameStuff.timer -= 30f;
            GameStuff.damageFlash = true;
        }
    }

    public void CloseCanvas()
    {
        gameObject.SetActive(false);
    }
}
