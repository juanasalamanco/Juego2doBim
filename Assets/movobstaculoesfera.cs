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
        float time = Time.time;

        if (time > 5) {

            if (transform.position.x <= 3.75f)
            {
                IsRight = false;
            }
            else if (transform.position.x >= 3.75f)
            {
                IsRight = true;
            }

            if (!IsRight)
            {
                transform.Translate(MovSpeed, 0, 0);
            }

            if (IsRight)
            {
                transform.Translate(-MovSpeed, 0, 0);
            }
        }
    }
}
