using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private string characterName; // con atributo SerializeField para guardar
    [SerializeField] private float characterHealth = 100; // vida del jugador
    [SerializeField] private float characterSpeed = 1;
    //public float damage; // da�o del jugador
    //public int age; //edad del jugador
    //public float defense;
    //public bool useRaytracing;
    //public double earthRotation;
    //public Vector2 gridPosition;
    //public Vector3 myPosition;
    //public Vector4 viewPosition;
    

    // Start is called before the first frame update
    void Start()
    {
        characterName = "Jack Harper Tech 49";
        characterSpeed = 2.2f;
    }

    // Update is called once per frame
    void Update()
    {
        
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
