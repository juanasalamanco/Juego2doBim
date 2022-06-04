using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObs2 : MonoBehaviour
{
    public float MovementObs;
    bool IsRight = true;

    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.Translate(-MovementObs, 0, 0);

        if (transform.position.x >= 3.75f)
        {
            IsRight = false;
            transform.Translate(-MovementObs, 0, 0);
        }
        else if (transform.position.x <= -3.75f)
        {
            IsRight = true;
            transform.Translate(MovementObs, 0, 0);
        }


        
    }
}
