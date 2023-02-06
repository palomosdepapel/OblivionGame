using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneGunScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        ShootingBullets();
    }
    public Transform gunTransform;
    public GameObject bulletPrefab;
    public float fireRate = 6;
    private float waitTillNextFire = 0.0f;
    void ShootingBullets()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (waitTillNextFire <= 0)
            {
                Instantiate(bulletPrefab, gunTransform.position, gunTransform.rotation);
                waitTillNextFire = 1;
            }
        }
        waitTillNextFire -= fireRate * Time.deltaTime;
    }
}
