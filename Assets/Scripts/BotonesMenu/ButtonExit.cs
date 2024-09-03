using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonExit : MonoBehaviour
{
    // PULSAR BOTON PLAY CAMBIA A ESCENA NIVELES
    public void BotonExit()
    {
        Debug.Log("Salimos de la Aplicación");
        Application.Quit();
    }
}
