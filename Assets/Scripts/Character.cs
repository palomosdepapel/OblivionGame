using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int age; //edad del jugador
    public float health; // vida del jugador
    public float damage; // daño del jugador
    public float defense;
    public bool useRaytracing;
    public double earthRotation;
    public Vector2 gridPosition;
    public Vector3 myPosition;
    public Vector4 viewPosition;
    [SerializeField] private string characterName; // con atributo SerializeField para guardar

    // Start is called before the first frame update
    void Start()
    {
        characterName = "Jack Harper Tech 49";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
