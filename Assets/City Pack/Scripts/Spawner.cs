using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    float spawntime;
    public float spawnrate;

    public GameObject sound;

    public List<GameObject> buildings = new List<GameObject>();

    GameObject bina;
    [SerializeField]GameObject binaprefab;
    // Start is called before the first frame update
    void Start()
    {
        bina = GameObject.Find("bina");

    }

    // Update is called once per frame
    void Update()
    {
        spawner();
    }

    void spawner()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {



            if (Time.time > spawntime)
            {
                spawntime = Time.time + spawnrate;

                Instantiate(sound);

                Vector3 binax = new Vector3(bina.transform.position.x, bina.transform.position.y + -2f, bina.transform.position.z);

                GameObject binalar = Instantiate(binaprefab, binax, Quaternion.identity);

                buildings.Add(binalar);




                



                Rigidbody2D bnrigidbody = binalar.GetComponent<Rigidbody2D>();
                /*bnrigidbody.AddForce(new Vector2(0f, -55f), ForceMode2D.Impulse);*/
                bnrigidbody.gravityScale = 1f;




            }
        }


    }



}
