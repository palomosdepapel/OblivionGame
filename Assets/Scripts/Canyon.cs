using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canyon : MonoBehaviour
{
    [SerializeField] private KeyCode Firebutton;
    public GameObject bullet;
    public float fireRate = 6;
    private float waitTillNextFire = 0.0f;
    public Transform gunTransform;

    // Update is called once per frame
    void Update()
    {
        ShottingBullets();
    }

    public void ShottingBullets()
    {
        if (Input.GetKey(Firebutton)) //GetKeyDown como cañon o GetKey como ametralladora
        {
            if (waitTillNextFire <= 0)
            {
                Instantiate(bullet,gunTransform.position, gunTransform.rotation);
                waitTillNextFire = 1;
                //Debug.Log("Fire!!!!");
            }
            
        }
        waitTillNextFire -= fireRate * Time.deltaTime;
    }


}
