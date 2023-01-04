using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int age; //edad del jugador
    public int health; // vida del jugador
    public float damage; // daño del jugador
    public bool useRaytracing;
    public double earthRotation;
    public Vector2 gridPosition;
    public Vector3 myPosition;
    public Quaternion viewPosition;
    [SerializeField] private string characterName; // con atributo SerializeField para guardar

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
