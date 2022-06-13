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

        transform.eulerAngles = (new Vector3(0, 0, 0));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && hasJump >= 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            hasJump = maxJump;
        }

        if (col.gameObject.name == "CuboParaGanar")
        {
            gameObject.transform.position = new Vector3(0, .5f, -9.5f);
        } 
    }
    
}
