using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    [SerializeField] private KeyCode Firebutton2;
    public GameObject bullet;
    public Transform origin;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Checkbottom2();
    }

    public void Checkbottom2()
    {
        Instantiate(bullet, origin);
        Debug.Log("Ratatatatatata!!!!");

    }


}
