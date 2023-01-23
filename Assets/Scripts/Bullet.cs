using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    [SerializeField] private int damage;
    [SerializeField] private float lifetime = 5;


    // Start is called before the first frame update
    void Start()
    {
        lifetime += Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Countdown();
    }
    private void Countdown()
    {
        Debug.Log(Time.time + " is current time");
        if (lifetime <= Time.time)
        {
            KillBullet();
        }
    }

    private void KillBullet()
    {
        Debug.Log("Bullet killed");
        Destroy(gameObject);
    }

    public void Movement()
    {
        transform.localPosition += direction * speed * Time.deltaTime;
    }
}
