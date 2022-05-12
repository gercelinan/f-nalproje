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
    bool bekleme=true;

    // Start is called before the first frame update
    void Start()
    {

        skor = 0;
        anaskor.text = "" + skor;
        Debug.Log(skor);
        
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

        yield return new WaitForSeconds(0.1f);
        bekleme = true;

    }
    private void Awake()
    {
        instance = this;
    }



}
