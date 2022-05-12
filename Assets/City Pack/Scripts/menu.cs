using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    bool menuacilis = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       /* if (Input.GetKeyUp(KeyCode.Escape)&& menuacilis == false)
        {
            mainmenu();
            menuacilis = true;

        }
        if (Input.GetKeyUp(KeyCode.Escape)&& menuacilis == true)
        {

            baslat();
            menuacilis = false;
        }
       */
        
    }

    public void baslat()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;

    }

    public void exit()
    {

        Application.Quit();
        Time.timeScale = 1;
    }

    public void mainmenu()
    {

        SceneManager.LoadScene("menu");
        Time.timeScale = 1;


    }
}
