using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletStuff : MonoBehaviour {

    public int damage;

    private void OnTriggerEnter(Collider other)
    {
        health thingy = other.gameObject.GetComponent<health>();
        if(thingy != null)
        {
            thingy.HP -= damage;
            Destroy(gameObject);
        }
        
    }
}
