using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public GameObject binaa;
    private void Update()
    {
        transform.position = new Vector2(transform.position.x,binaa.transform.position.y);
    }
}
