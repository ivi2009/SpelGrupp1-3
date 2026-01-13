using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameStuff : MonoBehaviour
{
    public TextMeshProUGUI livesGUI;
    public static float timer = 900;
    public static bool puzzle0Done = false;
    public static bool puzzle1Done = false;
    public static bool puzzle2Done = false;
    public static bool puzzle3Done = false;
    public GameObject folder;
    public Image damage;
    public Image correct;
    public static bool damageFlash = false;
    public static bool correctFlash = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        folder.SetActive(false);
        timer = 900;
        puzzle0Done = false;
        puzzle1Done = false;
        puzzle2Done = false;
        puzzle3Done = false;
        damageFlash = false;
        correctFlash = false;
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

        if (puzzle0Done && puzzle1Done && puzzle2Done && puzzle3Done)
        {
            SceneManager.LoadScene("Win screen");
        }
        //damage

        Color c = damage.color;
        if (damageFlash)
        {
            if (c.a < 1f)
            {
                c.a += 2f * Time.deltaTime; // ökar alpha
                damage.color = c;
            }
            if (c.a >= 1f) damageFlash = false;
        }
        if (!damageFlash && c.a > 0f)
        {
            c.a -= 2f * Time.deltaTime; // minskar alpha
            damage.color = c;
        }

        Color co = correct.color;
        if (correctFlash)
        {
            if (co.a < 1f)
            {
                co.a += 2f * Time.deltaTime; // ökar alpha
                correct.color = co;
            }
            if (co.a >= 1f) correctFlash = false;
        }
        if (!correctFlash && co.a > 0f)
        {
            co.a -= 2f * Time.deltaTime; // minskar alpha
            correct.color = co;
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

    public void Open3puzzle(GameObject puzzle)
    {
        if (!puzzle3Done) puzzle.SetActive(!puzzle.activeSelf);
    }

    public void OpenFolder()
    {
        folder.SetActive(!folder.activeSelf);
    }
}
