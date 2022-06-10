using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObs2 : MonoBehaviour
{
    public float MovementObs;
    
    public float xRightLimit;
    public float xLeftLimit;
    public bool toRight;

    void Start()
    {
        toRight = true;
    }

    void Update()
    {

        /*
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
        */

        if (toRight == true)
        {
            transform.position += new Vector3(MovementObs, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(MovementObs, 0, 0);
        }

        if (transform.position.x >= 3.75f)
        {
            toRight = false;
        }
        else if (transform.position.x <= -3.75f)
        {
            toRight = true;
        }


    }
}
