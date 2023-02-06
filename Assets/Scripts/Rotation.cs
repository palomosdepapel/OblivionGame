using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] public float rpm;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rpm,0,0);
    }
}
