using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private string characterName; // con atributo SerializeField para guardar
    [SerializeField] private float characterHealth = 100; // vida del jugador
    [SerializeField] private float characterSpeed = 1;
    [SerializeField] private float speed = 2;
    [SerializeField] private float maxSpeed = 100;
    [SerializeField] private float minSpeed = 1;
    [SerializeField] private float rootSpeed1 = 50;
    [SerializeField] private float rootSpeed2 = 50;


    // Start is called before the first frame update
    void Start()
    {
        characterName = "Jack Harper Tech 49";
        characterSpeed = 2.2f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (speed <= maxSpeed)
            {
                speed += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (speed >= minSpeed)
            {
                speed -= 1;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow) == Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rootSpeed2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rootSpeed2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) == Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left * rootSpeed1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) == Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right * rootSpeed1 * Time.deltaTime);
        }
    }

    // daño
    public void characterDamage()
    {
        characterHealth = characterHealth - 5;
    }

    // cura
    public void characterHeal()
    {
        characterHealth = characterHealth + 10;
    }
}
