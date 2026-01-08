using TMPro;
using UnityEngine;

public class Pussel1kod : MonoBehaviour
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
        }
        else
        {
            Debug.Log("fel");
        }
        //är koden korekt?
    }
}
