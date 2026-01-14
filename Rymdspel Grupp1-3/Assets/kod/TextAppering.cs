using System.Collections.Generic;
using UnityEngine;

public class TextAppering : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created'

    public List<GameObject> text;
    float timer = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime / 2.5f; //ökar timern med delta tid

        if (Mathf.RoundToInt(timer) <= text.Count) //visar text om timern är hög nog
        {
            text[Mathf.RoundToInt(timer)].SetActive(true);
        }
    }
}
