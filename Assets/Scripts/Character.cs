using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private string characterName; // Usualmente Tech49
    [SerializeField] private float characterHealth = 100; // vida del jugador
    [SerializeField] private float speed = 0; // Velocidad inicial
    [SerializeField] private float maxSpeed = 100; // Velocidad máxima
    [SerializeField] private float minSpeed = 0; // Velocidad mínima
    [SerializeField] private float rootSpeed1 = 50; // Velocidad inicial
    [SerializeField] private float rootSpeed2 = 50;


    // Start is called before the first frame update
    void Start()
    {
        characterName = "Jack Harper Tech 49";
        speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.F4)) // Incrementar velocidad
        {
            if (speed <= maxSpeed)
            {
                speed += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.F1)) //Reducir velocidad
        {
            if (speed >= minSpeed)
            {
                speed -= 1;
            }
        }
        // control de movimiento con las teclas de flechas o ADSW
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
