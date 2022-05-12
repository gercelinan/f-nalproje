using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FieldBliendaers : MonoBehaviour
{
    
    
    public float speed = 2.90f;
    public float speed1 = .1f;
    private bool carpisma=false;
  

    public void Start()
    {
        
        
        

        binileridon();

    }




    private void Update()
    {
       
    }

    void bingerýdon()
    {
        transform.DOMoveX(-11,speed).SetEase(Ease.Linear).OnComplete(()=> binileridon());
    }

    void binileridon()
    {
        transform.DOMoveX(11, speed).SetEase(Ease.Linear).OnComplete(() => bingerýdon());
        //  binamovement();
        //  Debug.Log(speed);


    }


    public void binaup()
    {
        transform.DOMoveY(transform.position.y+2, speed1).SetEase(Ease.Linear);


    }
    

   

}