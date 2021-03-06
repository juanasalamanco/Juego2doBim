using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathwallScript : MonoBehaviour
{
    public GameObject objectToClone;
    public int grados;
    public int clones;
    public GameObject Button;
    public GameObject textoganar;

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

        if (col.gameObject.name == "obstaculoSaltar")
        {
            gameObject.transform.position = new Vector3(0, .5f, -9.5f);
        }

        if(col.gameObject.name == "CuboParaGanar")
        {
            GameObject clon;
            for (int i = 0; i < clones; i++)
            {
                clon = Instantiate(objectToClone);
                //clon.transform.Rotate(0, grados * i, 0);
                //clon.transform.Translate(i, i, 0);

                Destroy(clon, 5f);
            }
        }

        if(col.gameObject.name == "Sphere")
        {
            gameObject.transform.position = new Vector3(0, .5f, -9.5f);
        }

        if (col.gameObject.name == "CuboParaGanar")
        {
            Button.SetActive(true);
            textoganar.SetActive(true);

        }
    }
  
    
    
}
