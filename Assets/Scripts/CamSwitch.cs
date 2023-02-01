using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    // Declaracion de variables
    public GameObject[] listaCamaras;
    int ncamaras = 3;

    private void Start()
    {
        // desactivamos las camaras
        for(int i=0; i<ncamaras; i++)
        {
            listaCamaras[i].gameObject.SetActive(false);
        }
        // activamos la primera camara
        listaCamaras[0].gameObject.SetActive(true);
    }

    void ApagarCamaras()
    {
        // desactivamos las camaras
        for (int i = 0; i < ncamaras; i++)
        {
            listaCamaras[i].gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Debug.Log("Oprimiste la tecla 1");
            ApagarCamaras();
            // activamos la primera camara
            listaCamaras[0].gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Debug.Log("Oprimiste la tecla 2");
            ApagarCamaras();
            // activamos la primera camara
            listaCamaras[1].gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Debug.Log("Oprimiste la tecla 3");
            ApagarCamaras();
            // activamos la primera camara
            listaCamaras[2].gameObject.SetActive(true);
        }
    }
}
