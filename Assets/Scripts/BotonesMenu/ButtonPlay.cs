using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    // PULSAR BOTON PLAY CAMBIA A ESCENA NIVELES
    public void BotonStart()
    {
        SceneManager.LoadScene(2);
    }
}