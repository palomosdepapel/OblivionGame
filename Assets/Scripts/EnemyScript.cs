using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // información de vida y velocidad
    [SerializeField] private string enemyName;
    [SerializeField] private float enemyHealth = 100; // vida del jugador
    [SerializeField] private float enemyRate = 5; // rata de velocidad
    // información para disparar y destruír al player
    public GameObject enemyBullet;
    public Transform spawnBulletPoint;
    private Transform playerPosition;
    public float bulletVelocity = 100;


    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //damage = 2;
        enemyName = "Drone 166";
        //enemySpeed = 0.1f;
        player = GameObject.Find("BubbleShip");
        playerPosition = FindObjectOfType<DroneMovementScript>().transform;
        Invoke("ShootPlayer", 3);
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
                Debug.Log("El drone ha sido destruído!!!");
            }
                
        }
    }
    void ShootPlayer() // método que dispara al player cada x tiempo
    {
        Vector3 playerDirection = playerPosition.position - transform.position;
        GameObject newBullet;
        newBullet = Instantiate(enemyBullet, spawnBulletPoint.position, spawnBulletPoint.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(playerDirection*bulletVelocity,ForceMode.Force);
        Invoke("ShootPlayer", 3);
    }
}
