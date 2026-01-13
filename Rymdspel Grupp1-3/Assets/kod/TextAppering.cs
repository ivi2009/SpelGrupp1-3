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
        timer += Time.deltaTime / 3;

        if (Mathf.RoundToInt(timer) <= text.Count)
        {
            text[Mathf.RoundToInt(timer)].SetActive(true);
        }
    }
}
