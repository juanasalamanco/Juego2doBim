using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movobstaculoesfera : MonoBehaviour
{
    bool ToRight = true;
    public float MovSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    

        if (ToRight == true)
        {
            transform.position += new Vector3(MovSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(MovSpeed, 0, 0);
        }

        if (transform.position.x >= 3.75f)
        {
            ToRight = false;
        }
        else if (transform.position.x <= -3.75f)
        {
            ToRight = true;
        }

    }
}
