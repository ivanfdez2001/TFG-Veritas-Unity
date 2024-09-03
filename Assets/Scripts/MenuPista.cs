using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPista : MonoBehaviour
{
    public GameObject Menupista;

    public void Pista()
    {
        Menupista.SetActive(true);
    }

    public void Salir()
    {
        Menupista.SetActive(false);
    }
}
