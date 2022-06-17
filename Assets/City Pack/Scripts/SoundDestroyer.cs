using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroyer());
    }

    public IEnumerator Destroyer()
    {
        yield return new WaitForSeconds(1.1f);
        Destroy(this.gameObject);
    }
}
