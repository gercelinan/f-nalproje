using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class spawnobjectcollision : MonoBehaviour
{
    
    /* 
     game manager(script) oluþtur
     public static int skor oluþtur 
     
    
     */
  



    private void OnCollisionEnter2D(Collision2D col)
    {
       
        if (col.gameObject.CompareTag("spawnbina"))
        {

            GameObject bina = GameObject.Find("bina");

            bina.GetComponent<FieldBliendaers>().binaup();
            StartCoroutine(gamemanager.instance.calculate());
           
            
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("deadzone"))
        {
            UIManager.Instance.ShowLosePanel(); 
            
        }
    }


}
