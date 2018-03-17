using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDestroyer : MonoBehaviour {


    void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
      
        yield return new WaitForSeconds(5);
        Destroy(gameObject);

    }
}
