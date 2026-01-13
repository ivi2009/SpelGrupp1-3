using UnityEngine;

public class VisaBild : MonoBehaviour
{
    bool påVägg = true;
    public GameObject papper;
    public GameObject papper2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        papper.SetActive(true);
        papper2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PapperGrej()
    {
        if (påVägg)
        {
            påVägg = false;
            papper.SetActive(false);
            papper2.SetActive(true);
        }

        else
        {
            påVägg = true;
            papper.SetActive(true);
            papper2.SetActive(false);
        }
    }


}
