using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canyon : MonoBehaviour
{
    [SerializeField] private KeyCode Firebutton;
    public GameObject bullet;
    public Transform origin;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Checkbottom();
    }

    public void Checkbottom()
    {
        if (Input.GetKeyDown(Firebutton))
        {
            Instantiate(bullet,origin);
        }
    }

}
