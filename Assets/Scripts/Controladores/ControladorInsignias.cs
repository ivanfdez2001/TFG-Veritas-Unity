using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorInsignias : MonoBehaviour
{
    public static ControladorInsignias instancia;
    public Button[] botonesInsignias;
    public int desbloquearInsignias;

    private void Awake()
    {
        if(instancia == null)
        {
            instancia = this;
        }
    }

    private void Start()
    {
        if(botonesInsignias.Length > 0)
        {
            for (int i = 0; i < botonesInsignias.Length; i++)
            {
                botonesInsignias[i].interactable = false;
            }

            for(int i = 0; i < PlayerPrefs.GetInt("AI18", 0); i++)
            {
                botonesInsignias[i].interactable = true;
            }
        }
    }

    public void AumentarInsignias()
    {
        if(desbloquearInsignias > PlayerPrefs.GetInt("AI18", 0))
        {
            PlayerPrefs.SetInt("AI18", desbloquearInsignias);
        }
    }
}
