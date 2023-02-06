using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScale : MonoBehaviour
{
    public bool pauseGame; // si es false No hay pausa, si es true, estará pausado

    // La tecla P detiene el juego
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pauseGame == false)
            {
                Time.timeScale = 0;
                pauseGame = true;
            }
            else
            {
                Time.timeScale = 1;
                pauseGame = false;

            }
        }
    }
}

