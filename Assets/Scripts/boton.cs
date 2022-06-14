using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boton : MonoBehaviour
{
    public GameObject Cubo;
    public GameObject Boton;
    public GameObject TextoGanar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ganar()
    {
        Cubo.transform.position = new Vector3(0, .5f, -9.5f);
        Boton.SetActive(false);
        TextoGanar.SetActive(false);
    }
}
