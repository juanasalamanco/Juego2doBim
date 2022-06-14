using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movDeathWall : MonoBehaviour
{
    public float movementSpeed;
    public GameObject Deathwall;
    void Start()
    {
        
    }

    void Update()
    {
        float time = Time.time;
        if (time > 5)
        {
            transform.Translate(0, 0, movementSpeed);
        }
    }

}
