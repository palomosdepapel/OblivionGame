using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Input.GetAxis("Mouse Y"),0,0);
    }
}
