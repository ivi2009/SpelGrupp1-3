using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStuff : MonoBehaviour
{
    public TextMeshProUGUI livesGUI;
    public static int lives = 5;
    public static bool puzzle0Done = false;
    public static bool puzzle1Done = false;
    public static bool puzzle2Done = false;
    int maxlives = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lives = maxlives;
    }

    // Update is called once per frame
    void Update()
    {
        livesGUI.text = lives.ToString() + "/5 Lives";
        if (lives <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    public void Open0puzzle(GameObject puzzle)
    {
        if (!puzzle0Done) puzzle.SetActive(!puzzle.activeSelf);
    }

    public void Open1puzzle(GameObject puzzle)
    {
        if (!puzzle1Done) puzzle.SetActive(!puzzle.activeSelf);
    }

    public void Open2puzzle(GameObject puzzle)
    {
        if (!puzzle2Done) puzzle.SetActive(!puzzle.activeSelf);
    }

}
