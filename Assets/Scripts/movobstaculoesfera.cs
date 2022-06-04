using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movobstaculoesfera : MonoBehaviour
{
    bool IsRight = true;
    public float MovSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.Translate(MovSpeed, 0, 0);

        if (transform.position.x <= 3.75f)
        {
            IsRight = false;
            transform.Translate(MovSpeed, 0, 0);
        }
        else if (transform.position.x >= -3.75f)
        {
            IsRight = true;
            transform.Translate(-MovSpeed, 0, 0);
        }


        if (transform.position.x >= 3.75f)
        {
            IsRight = true;
            transform.Translate(-MovSpeed, 0, 0);
        }
        else if (transform.position.x <= -3.75f)
        {
            IsRight = false;
            transform.Translate(MovSpeed, 0, 0);
        }

        /*
        if (!IsRight)
        {
            transform.Translate(MovSpeed, 0, 0);
        }
        else if (IsRight)
        {
            
            transform.Translate(-MovSpeed, 0, 0);
        }
        */

    }
}
