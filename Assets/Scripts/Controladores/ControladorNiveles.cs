using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ControladorNiveles : MonoBehaviour
{
    public static ControladorNiveles instancia;
    public Button[] botonesNiveles;
    public int desbloquearNiveles;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
    }

    private void Start()
    {
        if (botonesNiveles.Length > 0)
        {
            for (int i = 0; i < botonesNiveles.Length; i++)
            {
                botonesNiveles[i].interactable = false;
            }

            for (int i = 0; i < PlayerPrefs.GetInt("AN18", 1); i++)
            {
                botonesNiveles[i].interactable = true;
            }
        }
    }

    public void AumentarNiveles()
    {
        if (desbloquearNiveles > PlayerPrefs.GetInt("AN18", 1))
        {
            PlayerPrefs.SetInt("AN18", desbloquearNiveles);
        }
    }
}
