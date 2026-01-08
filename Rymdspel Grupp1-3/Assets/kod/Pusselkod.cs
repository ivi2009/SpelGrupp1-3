using TMPro;
using UnityEngine;

public class Pusselkod : MonoBehaviour
{
    public TMP_InputField codeInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IsCodeCorect(string rightCode)
    {
        if ((codeInput.text).ToLower() == rightCode)
        {
            Debug.Log("rätt");
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("fel");
            GameStuff.lives--;
        }
        //är koden korekt?
    }

    public void CloseCanvas()
    {
        gameObject.SetActive(false);
    }
}
