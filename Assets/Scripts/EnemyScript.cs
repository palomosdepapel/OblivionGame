using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private string enemyName;
    [SerializeField] private float enemyHealth = 100; // vida del jugador
    [SerializeField] private float enemySpeed = 1;
    [SerializeField] private Vector3 directionEnemy;
    GameObject player;
    //[SerializeField] private Vector3 size;
    //public float enemySpeed;
    //public float damage;
    //[SerializeField] private Character character;

    // Start is called before the first frame update
    void Start()
    {
        //damage = 2;
        enemyName = "Drone 166";
        enemySpeed = 0.1f;
        player = GameObject.Find("Bubleship");
        // vida CHAR = vida CHAR - daño ES - defensa CHAR
        // character.health = character.health - damage - character.defense;
        // character.health -= damage - character.defense;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform); // el enemigo rota hacia el player
        Movement(0.1f, new Vector3(0, 0.01f, 0));
        
        //Debug.Log("Te speed is: " + enemySpeed);
        //transform.position += movement;
        //transform.localScale += size;
        //transform.position += enemySpeed * Time.deltaTime * transform.forward;

    }

    // daño
    public void enemyDamage()
    {
        enemyHealth = enemyHealth -2;
    }

    // cura
    public void enemyHeal()
    {
        enemyHealth = enemyHealth + 5;
    }

    
    public void increaseEnemySpeed()
    {
        enemySpeed += 1;
    }

    public void decreaseEnemySpeed()
    {
        enemySpeed -= 1;
    }

    public void Movement(float speedEnemy, Vector3 directionEnemy)
    {
        //transform.position += transform.position * enemySpeed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        //Debug.Log("The current altitude of the enemy is: " + transform.position.y);
    }


}
