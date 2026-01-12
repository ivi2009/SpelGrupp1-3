using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Pussel3 : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    int kanal1 = 1;
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
        kanal1++;

        if (kanal1 == 10)
        {
            kanal1 = 1;
        }
        if (kanal1 == 1)
        {
            cb.normalColor = Color.white;
            cb.selectedColor = Color.white;
            cb.highlightedColor = Color.white;
            tmp.text = "1";
        }
        if (kanal1 == 2)
        {
            cb.normalColor = Color.red;
            cb.selectedColor = Color.red;
            cb.highlightedColor = Color.red;
            tmp.text = "2";
        }
        if (kanal1 == 3)
        {
            cb.normalColor = Color.blue;
            cb.selectedColor = Color.blue;
            cb.highlightedColor = Color.blue;
            tmp.text = "3";
        }
        if (kanal1 == 4)
        {
            cb.normalColor = Color.orange;
            cb.selectedColor = Color.orange;
            cb.highlightedColor = Color.orange;
            tmp.text = "4";
        }
        if (kanal1 == 5)
        {
            cb.normalColor = Color.pink;
            cb.selectedColor = Color.pink;
            cb.highlightedColor = Color.pink;
            tmp.text = "5";
        }
        if (kanal1 == 6)
        {
            cb.normalColor = Color.purple;
            cb.selectedColor = Color.purple;
            cb.highlightedColor = Color.purple;
            tmp.text = "6";
        }
        if (kanal1 == 7)
        {
            cb.normalColor = Color.brown;
            cb.selectedColor = Color.brown;
            cb.highlightedColor = Color.brown;
            tmp.text = "7";
        }
        if (kanal1 == 8)
        {
            cb.normalColor = Color.yellow;
            cb.selectedColor = Color.yellow;
            cb.highlightedColor = Color.yellow;
            tmp.text = "8";
        }
        if (kanal1 == 9)
        {
            cb.normalColor = Color.black;
            cb.selectedColor = Color.black;
            cb.highlightedColor = Color.black;
            tmp.text = "9";
        }
        button.colors = cb;
    }

}
