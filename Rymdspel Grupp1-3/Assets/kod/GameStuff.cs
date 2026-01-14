using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameStuff : MonoBehaviour
{
    public AudioSource pop;
    public TextMeshProUGUI livesGUI;
    public static float timer = 900;

    public static List<bool> DonePuzzles = new List<bool>();
    public GameObject folder;
    public Image damage;
    public Image correct;
    public static bool damageFlash = false;
    public static bool correctFlash = false;

    public GameObject puzzle0overline;
    public GameObject puzzle1overline;
    public GameObject puzzle2overline;
    public GameObject puzzle3overline;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //alla public variablar resättas
        folder.SetActive(false);
        timer = 900;

        damageFlash = false;
        correctFlash = false;

        puzzle0overline.SetActive(false);
        puzzle1overline.SetActive(false);
        puzzle2overline.SetActive(false);
        puzzle3overline.SetActive(false);

        DonePuzzles.Clear();
        DonePuzzles.AddRange(new List<bool>
        {
            false, false, false, false
        });
    }

    // Update is called once per frame
    void Update()
    {
        //timer
        livesGUI.text = Mathf.RoundToInt(timer).ToString();
        timer -= Time.deltaTime;

        //är timern noll? isåfall förlora
        if (timer <= 0)
        {
            SceneManager.LoadScene(6);
        }

        //är pusslerna fördiga? isåfall vinn
        if (DonePuzzles[0] && DonePuzzles[1] && DonePuzzles[2] && DonePuzzles[3])
        {
            SceneManager.LoadScene(7);
        }

        //damageflash
        Color c = damage.color;
        if (damageFlash)
        {
            if (c.a < 1f)
            {
                c.a += 2f * Time.deltaTime; // öka långsamt alpha på damageflash
                damage.color = c;
            }
            if (c.a >= 1f) damageFlash = false; //om alphan är max börja minska
        }
        if (!damageFlash && c.a > 0f)
        {
            c.a -= 2f * Time.deltaTime; // minskar ångsamt alpha på damageflash
            damage.color = c;
        }

        //winflash (grön fan, som kommer upp när man har rätt)
        Color co = correct.color;
        if (correctFlash)
        {
            if (co.a < 1f)
            {
                co.a += 2f * Time.deltaTime; //öka långsamt alpha på winflash
                correct.color = co;
            }
            if (co.a >= 1f) correctFlash = false;
        }
        if (!correctFlash && co.a > 0f) //om alphan är max börja minska
        {
            co.a -= 2f * Time.deltaTime; //öka långsamt alpha på winflash
            correct.color = co;
        }

        //är något puzzel färdigt? dra då ett strek över det i foldern
        if (DonePuzzles[0]) puzzle0overline.SetActive(true);
        if (DonePuzzles[1]) puzzle1overline.SetActive(true);
        if (DonePuzzles[2]) puzzle2overline.SetActive(true);
        if (DonePuzzles[3]) puzzle3overline.SetActive(true);
    }

    //de fyra följande funktonerna är ass, men man kan bara ha en variabel när man kallar en funktion från en knapp
    public void Open0puzzle(GameObject puzzle) //kollar om puzzel 0 är ofärdigt och öppnar isåfall det
    {
        if (!DonePuzzles[0]) puzzle.SetActive(!puzzle.activeSelf);
    }

    public void Open1puzzle(GameObject puzzle) //kollar om puzzel 1 är ofärdigt och öppnar isåfall det
    {
        if (!DonePuzzles[1]) puzzle.SetActive(!puzzle.activeSelf);
    }

    public void Open2puzzle(GameObject puzzle) //kollar om puzzel 2 är ofärdigt och öppnar isåfall det
    {
        if (!DonePuzzles[2]) puzzle.SetActive(!puzzle.activeSelf);
    }

    public void Open3puzzle(GameObject puzzle) //kollar om puzzel 3 är ofärdigt och öppnar isåfall det
    {
        if (!DonePuzzles[3]) puzzle.SetActive(!puzzle.activeSelf);
    }

    //öppnar foldern
    public void OpenFolder()
    {
        folder.SetActive(!folder.activeSelf);
    }

    // öppnar/stänger pussel
    public void OpenCanva(GameObject canva)
    {
        canva.SetActive(!canva.activeSelf);
    }

    //spelar ljud-effect
    public void PlayPop()
    {
        pop.Play();
    }
}
