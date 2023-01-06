using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private string enemyName;
    public float enemyHealth = 100; // vida del jugador
    public float enemySpeed = 1;
    [SerializeField] private Vector3 direction;
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
        // vida CHAR = vida CHAR - daño ES - defensa CHAR
        // character.health = character.health - damage - character.defense;
        // character.health -= damage - character.defense;
    }

    // Update is called once per frame
    void Update()
    {
        Movement(0.1f, new Vector3(0, 0.01f, 0));
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

    public void Movement(float speedEnemy, Vector3 direction)
    {
        transform.position += transform.position * enemySpeed * Time.deltaTime;
    }

}
