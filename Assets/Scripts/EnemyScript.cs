using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private string enemyName;
    [SerializeField] private Vector3 movement;
    [SerializeField] private Vector3 size;
    public float enemySpeed;
    public float damage;
    [SerializeField] private Character character;

    // Start is called before the first frame update
    void Start()
    {
        damage = 2;
        enemyName = "Drone 166";
        enemySpeed = 1;
        // vida CHAR = vida CHAR - daño ES - defensa CHAR
        // character.health = character.health - damage - character.defense;
        character.health -= damage - character.defense;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movement;
        transform.localScale += size;
        transform.position += enemySpeed * Time.deltaTime * transform.forward;
    }
}
