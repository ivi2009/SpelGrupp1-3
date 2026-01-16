using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameStuff : MonoBehaviour
{
    public AudioSource pop;
    public AudioSource alarm;
    public TextMeshProUGUI livesGUI;
    public static float timer = 900;

    public static List<bool> DonePuzzles = new List<bool>();
    public GameObject folder;
    public Image damage;
    public Image correct;
    public static bool damageFlash = false;
    public static bool correctFlash = false;
    public List<GameObject> overLines = new List<GameObject>();
    public List<GameObject> puzzles = new List<GameObject>();

    float flashTime = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //alla public variablar resättas
        folder.SetActive(false);
        timer = 900;

        damageFlash = false;
        correctFlash = false;

        for (int i = 0; i < overLines.Count; i++)
        {
            overLines[i].SetActive(false);
        }

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

        //är timern < 20? spela alarm
        if (timer < 20 && !alarm.isPlaying)
        {
            alarm.Play();
        }
        //är timern noll? isåfall förlora
        if (timer <= 0)
        {
            alarm.Stop();
            SceneManager.LoadScene(6);
        }

        //är pusslerna fördiga? isåfall vinn
        if (DonePuzzles[0] && DonePuzzles[1] && DonePuzzles[2] && DonePuzzles[3])
        {
            if (alarm.isPlaying) alarm.Stop();
            SceneManager.LoadScene(7);
        }

        //damageflash
        Color c = damage.color;
        if (damageFlash)
        {
            if (c.a < 1f)
            {
                c.a += flashTime * Time.deltaTime; // öka långsamt alpha på damageflash
                damage.color = c;
            }
            if (c.a >= 1f) damageFlash = false; //om alphan är max börja minska
        }
        if (!damageFlash && c.a > 0f)
        {
            c.a -= flashTime * Time.deltaTime; // minskar ångsamt alpha på damageflash
            damage.color = c;
        }

        //winflash (grön fan, som kommer upp när man har rätt)
        Color co = correct.color;
        if (correctFlash)
        {
            if (co.a < 1f)
            {
                co.a += flashTime * Time.deltaTime; //öka långsamt alpha på winflash
                correct.color = co;
            }
            if (co.a >= 1f) correctFlash = false;
        }
        if (!correctFlash && co.a > 0f) //om alphan är max börja minska
        {
            co.a -= flashTime * Time.deltaTime; //minska långsamt alpha på winflash
            correct.color = co;
        }

        //är något puzzel färdigt? dra då ett strek över det i foldern
        for (int i = 0; i < overLines.Count; i++)
        {
            if (DonePuzzles[i]) overLines[i].SetActive(true);
        }
    }

    public void OpenPuzzle(int puzzleID) //kollar om pussel x är ofärdigt och öppnar isåfall det
    {
        bool canOpen = true;
        for (int i = 0; i < puzzles.Count; i++) // är något annat pussel färdigt?
        {
            if (i == puzzleID) continue;
            if (puzzles[i].activeSelf == true) canOpen = false;
        }
        if (!DonePuzzles[puzzleID] && canOpen) //är pusslet avkalrat?
        {
            puzzles[puzzleID].SetActive(!puzzles[puzzleID].activeSelf);
        }
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
