using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Pussel3 : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    int kanal = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ÄndraSkärm()
    {
        Button button = GetComponent<Button>();
        ColorBlock cb = button.colors;
        kanal++;

        if (kanal == 6)
        {
            kanal = 1;
        }
        if (kanal == 1)
        {
            cb.normalColor = Color.red;
            cb.selectedColor = Color.red;
            cb.highlightedColor = Color.red;
            tmp.text = "1";
        }
        if (kanal == 2)
        {
            cb.normalColor = Color.blue;
            cb.selectedColor = Color.blue;
            cb.highlightedColor = Color.blue;
            tmp.text = "2";
        }
        if (kanal == 3)
        {
            cb.normalColor = Color.pink;
            cb.selectedColor = Color.pink;
            cb.highlightedColor = Color.pink;
            tmp.text = "3";
        }
        if (kanal == 4)
        {
            cb.normalColor = Color.yellow;
            cb.selectedColor = Color.yellow;
            cb.highlightedColor = Color.yellow;
            tmp.text = "4";
        }
        if (kanal == 5)
        {
            cb.normalColor = Color.green;
            cb.selectedColor = Color.green;
            cb.highlightedColor = Color.green;
            tmp.text = "5";
        }
        button.colors = cb;
    }

}
