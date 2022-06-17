using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{

    public static gamemanager instance;
    public float skor;
    public TextMeshProUGUI anaskor;
    public Text highScore;
    bool bekleme=true;

    // Start is called before the first frame update
    void Start()
    {
        
        skor = 0;
        anaskor.text = "" + skor;
        //Debug.Log(skor);

        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();

        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public IEnumerator calculate()
    {
       
        
        if (bekleme)
        {
           
            skor++;

            anaskor.text = "" + skor;
            Debug.Log(skor);

            

            bekleme = false;

        }

        if (skor > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", skor);
            highScore.text = skor.ToString();
        }

        Debug.Log("skor " + skor);
        Debug.Log("HighScore " +PlayerPrefs.GetFloat("HighScore"));

        yield return new WaitForSeconds(0.1f);
        bekleme = true;

    }
    private void Awake()
    {
        instance = this;
    }



}
