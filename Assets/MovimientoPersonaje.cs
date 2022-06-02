using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public int maxJump;

    int hasJump;
    Rigidbody rb;

    void Start()
    {
        hasJump = maxJump;
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.A) && hasJump == maxJump)
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) && hasJump == maxJump)
        {
            transform.Translate(movementSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space) && hasJump>0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "ground")
        {
            hasJump = maxJump;
        }
    }
}
