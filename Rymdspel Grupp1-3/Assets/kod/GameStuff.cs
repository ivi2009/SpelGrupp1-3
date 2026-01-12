using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStuff : MonoBehaviour
{
    public TextMeshProUGUI livesGUI;
    public static float timer = 300;
    public static bool puzzle0Done = false;
    public static bool puzzle1Done = false;
    public static bool puzzle2Done = false;
    public GameObject folder;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 300;
        puzzle0Done = false;
        puzzle1Done = false;
        puzzle2Done = false;
    }

    // Update is called once per frame
    void Update()
    {
        livesGUI.text = Mathf.RoundToInt(timer).ToString();
        timer -= Time.deltaTime;
        if (timer <= 0)
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

    public void OpenFolder()
    {
        folder.SetActive(!folder.activeSelf);
    }
}
