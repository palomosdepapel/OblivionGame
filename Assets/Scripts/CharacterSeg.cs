using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSeg : MonoBehaviour
{
    [SerializeField] private string characterName; // Usualmente Tech49
    [SerializeField] private float characterHealth = 100; // vida del jugador
    [SerializeField] private float speed = 0; // Velocidad inicial
    [SerializeField] private float maxSpeed = 100; // Velocidad m�xima
    [SerializeField] private float minSpeed = 0; // Velocidad m�nima
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
        //transform.Translate(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += transform.forward * speed * Time.deltaTime;
        transform.Rotate(0,Input.GetAxis("Mouse X"),0);

        if (Input.GetKeyDown(KeyCode.F4)) // Incrementar velocidad
        {
            if (speed <= maxSpeed)
            {
                speed += 5;
            }
        }
        if (Input.GetKeyDown(KeyCode.F3)) //Incrementar velocidad
        {
            if (speed <= maxSpeed)
            {
                speed += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.F2)) //Reducir velocidad
        {
            if (speed >= minSpeed)
            {
                speed -= 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.F1)) //Reducir velocidad
        {
            if (speed >= minSpeed)
            {
                speed -= 5;
            }
        }
        // control de movimiento con las teclas de flechas o ADSW
        // derecha
        if (Input.GetKey(KeyCode.RightArrow) == Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rootSpeed2 * Time.deltaTime);
        }
        // izquierda
        if (Input.GetKey(KeyCode.LeftArrow) == Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rootSpeed2 * Time.deltaTime);
        }
        // adelante
        if (Input.GetKey(KeyCode.UpArrow) == Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left * rootSpeed1 * Time.deltaTime);
        }
        // atras
        if (Input.GetKey(KeyCode.DownArrow) == Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right * rootSpeed1 * Time.deltaTime);
        }
    }

    // da�o
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
