using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float alertRange;
    public LayerMask playerLayer;
    bool beAlert;
    public Transform searchPlayer;
    public float speed;
    [SerializeField] private string enemyName;
    [SerializeField] private float enemyHealth = 100; // vida del jugador
    [SerializeField] private float enemyRate = 5; // rata de velocidad
    // información para disparar y destruír al player
    public GameObject enemyBullet;
    public Transform spawnBulletPoint;
    private Transform playerPosition;
    public float bulletVelocity = 1;

    private void Start()
    {
        //Invoke("ShootPlayer", 3);
    }
    // Update is called once per frame
    void Update()
    {
        beAlert = Physics.CheckSphere(transform.position, alertRange, playerLayer);
        if (beAlert == true)
        {
            //transform.LookAt(searchPlayer);
            Vector3 positionPlayer = new Vector3(searchPlayer.position.x, searchPlayer.position.y, searchPlayer.position.z);
            transform.LookAt(positionPlayer); // watch the player
            transform.position = Vector3.MoveTowards(transform.position, positionPlayer, speed * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, alertRange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "BubbleShip")
            Debug.Log("El drone nos ha impactado");
        if (collision.collider.tag == "Bullet")
        {
            Destroy(collision.collider.gameObject);
            enemyHealth -= 5;

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
        newBullet.GetComponent<Rigidbody>().AddForce(playerDirection * bulletVelocity, ForceMode.Force);
        Invoke("ShootPlayer", 3);
    }
}

