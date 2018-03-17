 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroyer : MonoBehaviour {

    public GameObject itemToSpawn;

    private void OnDestroy()
    {
        Instantiate(itemToSpawn, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }
}
