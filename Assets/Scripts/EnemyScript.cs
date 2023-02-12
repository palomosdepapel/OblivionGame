using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private string enemyName;
    [SerializeField] private float enemyHealth = 100; // vida del jugador
    [SerializeField] private float enemyRate = 5;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //damage = 2;
        enemyName = "Drone 166";
        //enemySpeed = 0.1f;
        player = GameObject.Find("BubbleShip");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform); // el enemigo rota (mira) hacia el player
        GetComponent<Rigidbody>().velocity = transform.forward * enemyRate;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "BubbleShip")
            Debug.Log("El drone nos ha impactado");
        if (collision.collider.tag == "Bullet")
        {
            Destroy(collision.collider.gameObject);
            enemyHealth -= 30;
            
            if (enemyHealth <= 0)
            {
                Destroy(gameObject);
            }
                
        }


    }
}
