using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStuff : MonoBehaviour
{
    public TextMeshProUGUI livesGUI;
    public static int lives = 5;
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

    public void OpenPuzzle(GameObject puzzle)
    {
        puzzle.SetActive(!puzzle.activeSelf);
    }
}
