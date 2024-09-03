using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorIconoInsignias : MonoBehaviour
{
    public static ControladorIconoInsignias instancia;
    public Button[] botonesIconoInsignias;
    public int desbloquearIconoInsignias;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
    }

    private void Start()
    {
        if (botonesIconoInsignias.Length > 0)
        {
            for (int i = 0; i < botonesIconoInsignias.Length; i++)
            {
                botonesIconoInsignias[i].interactable = false;
            }

            for (int i = 0; i < PlayerPrefs.GetInt("AII18", 0); i++)
            {
                botonesIconoInsignias[i].interactable = true;
            }
        }
    }

    public void AumentarIconoInsignias()
    {
        if (desbloquearIconoInsignias > PlayerPrefs.GetInt("AII18", 0))
        {
            PlayerPrefs.SetInt("AII18", desbloquearIconoInsignias);
        }
    }
}
