using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] public float velocidad;
    [SerializeField] public float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*0.1f,0,Input.GetAxis("Vertical")*0.1f);
        if (Input.GetKey(KeyCode.F))
            GetComponent<Rigidbody>().AddForce(0, fuerza, 0);
    }
}
