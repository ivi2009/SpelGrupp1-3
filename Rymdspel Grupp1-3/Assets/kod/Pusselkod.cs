using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pusselkod : MonoBehaviour
{
    public AudioSource buzzer;
    public AudioSource correct;
    public TMP_InputField codeInput;
    public static List<string> codes = new List<string>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        codes.Clear();
        codes.AddRange(new List<string> //rätta svaren
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
            gameObject.SetActive(false);    //om ja, stäng menyn mm
            GameStuff.DonePuzzles[puzzleID] = true;

            GameStuff.correctFlash = true;
            correct.Play();
        }
        else
        {
            buzzer.Play();          //om nej, ta bort från timern mm
            GameStuff.timer -= 30f;
            GameStuff.damageFlash = true;
        }
    }

    public void CloseCanvas() //sänger valfri canvas (när man trycker på "back")
    {
        gameObject.SetActive(false);
    }
}
