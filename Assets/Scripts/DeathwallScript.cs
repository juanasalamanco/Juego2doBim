using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathwallScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "deathwall")
        {
            gameObject.transform.position = new Vector3(0,.5f,-9.5f);
        }
        
        if(col.gameObject.name == "pisoMuerte")
        {
            gameObject.transform.position = new Vector3(0, .5f, -9.5f);
        }
    }
    
}
