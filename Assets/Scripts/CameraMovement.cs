using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Input.GetAxis("Mouse Y"),0,0); // Vista libre en "Y" dentro de la cabina con el movimiento del ratón
    }
}
