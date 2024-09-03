using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonReturn : MonoBehaviour
{
    // PULSAR BOTON RETURN EN MENU NIVELES CAMBIA A ESCENA MENU PRINCIPAL
    public void BotonReturnMenuPrincipal()
    {
        SceneManager.LoadScene(1);
    }

    // PULSAR BOTON RETURN EN CUALQUIER NIVEL CAMBIA A ESCENA MENU NIVELES
    public void BotonReturnMenuNiveles()
    {
        SceneManager.LoadScene(2);
    }

    //--------------------------------- NIVEL 1 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 1 VUELVE A INICIAR NIVEL 1
    public void BotonRetryLevel1()
    {
        SceneManager.LoadScene(3);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 1 CAMBIA A NIVEL 2
    public void BotonCompleteLevel1()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();
        
        SceneManager.LoadScene(8);
    }

    //--------------------------------- NIVEL 2 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 2 VUELVE A INICIAR NIVEL 2
    public void BotonRetryLevel2()
    {
        SceneManager.LoadScene(10);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 2 CAMBIA A NIVEL 3
    public void BotonCompleteLevel2()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(15);
    }

    //--------------------------------- NIVEL 3 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 3 VUELVE A INICIAR NIVEL 3
    public void BotonRetryLevel3()
    {
        SceneManager.LoadScene(17);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 3 CAMBIA A NIVEL 4
    public void BotonCompleteLevel3()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(22);
    }

    //--------------------------------- NIVEL 4 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 4 VUELVE A INICIAR NIVEL 4
    public void BotonRetryLevel4()
    {
        SceneManager.LoadScene(24);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 4 CAMBIA A NIVEL 5
    public void BotonCompleteLevel4()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(29);
    }

    //--------------------------------- NIVEL 5 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 5 VUELVE A INICIAR NIVEL 5
    public void BotonRetryLevel5()
    {
        SceneManager.LoadScene(31);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 5 CAMBIA A NIVEL 6
    public void BotonCompleteLevel5()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(36);
    }

    //--------------------------------- NIVEL 6 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 6 VUELVE A INICIAR NIVEL 6
    public void BotonRetryLevel6()
    {
        SceneManager.LoadScene(38);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 6 CAMBIA A NIVEL 7
    public void BotonCompleteLevel6()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(43);
    }

    //--------------------------------- NIVEL 7 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 7 VUELVE A INICIAR NIVEL 7
    public void BotonRetryLevel7()
    {
        SceneManager.LoadScene(45);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 7 CAMBIA A NIVEL 8
    public void BotonCompleteLevel7()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(50);
    }

    //--------------------------------- NIVEL 8 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 8 VUELVE A INICIAR NIVEL 8
    public void BotonRetryLevel8()
    {
        SceneManager.LoadScene(52);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 8 CAMBIA A NIVEL 9
    public void BotonCompleteLevel8()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(57);
    }

    //--------------------------------- NIVEL 9 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 9 VUELVE A INICIAR NIVEL 9
    public void BotonRetryLevel9()
    {
        SceneManager.LoadScene(59);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 9 CAMBIA A NIVEL 10
    public void BotonCompleteLevel9()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(64);
    }

    //--------------------------------- NIVEL 10 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 10 VUELVE A INICIAR NIVEL 10
    public void BotonRetryLevel10()
    {
        SceneManager.LoadScene(66);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 10 CAMBIA A NIVEL 11
    public void BotonCompleteLevel10()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(71);
    }

    //--------------------------------- NIVEL 11 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 11 VUELVE A INICIAR NIVEL 11
    public void BotonRetryLevel11()
    {
        SceneManager.LoadScene(73);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 11 CAMBIA A NIVEL 12
    public void BotonCompleteLevel11()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(78);
    }

    //--------------------------------- NIVEL 12 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 12 VUELVE A INICIAR NIVEL 12
    public void BotonRetryLevel12()
    {
        SceneManager.LoadScene(80);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 12 CAMBIA A NIVEL 13
    public void BotonCompleteLevel12()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(85);
    }

    //--------------------------------- NIVEL 13 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 13 VUELVE A INICIAR NIVEL 13
    public void BotonRetryLevel13()
    {
        SceneManager.LoadScene(87);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 13 CAMBIA A NIVEL 14
    public void BotonCompleteLevel13()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(92);
    }

    //--------------------------------- NIVEL 14 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 14 VUELVE A INICIAR NIVEL 14
    public void BotonRetryLevel14()
    {
        SceneManager.LoadScene(94);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 14 CAMBIA A NIVEL 15
    public void BotonCompleteLevel14()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(99);
    }

    //--------------------------------- NIVEL 15 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 15 VUELVE A INICIAR NIVEL 15
    public void BotonRetryLevel15()
    {
        SceneManager.LoadScene(101);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 15 CAMBIA A NIVEL 16
    public void BotonCompleteLevel15()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(106);
    }

    //--------------------------------- NIVEL 16 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 16 VUELVE A INICIAR NIVEL 16
    public void BotonRetryLevel16()
    {
        SceneManager.LoadScene(108);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 16 CAMBIA A NIVEL 17
    public void BotonCompleteLevel16()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(113);
    }

    //--------------------------------- NIVEL 17 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 17 VUELVE A INICIAR NIVEL 17
    public void BotonRetryLevel17()
    {
        SceneManager.LoadScene(115);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 17 CAMBIA A NIVEL 18
    public void BotonCompleteLevel17()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(120);
    }

    //--------------------------------- NIVEL 18 ----------------------------------------

    // PULSAR BOTON RETRY LEVEL EN NIVEL 18 VUELVE A INICIAR NIVEL 18
    public void BotonRetryLevel18()
    {
        SceneManager.LoadScene(122);
    }

    // PULSAR BOTON LEVEL COMPLETE EN NIVEL 18 CAMBIA A MENU PRINCIPAL
    public void BotonCompleteLevel18()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(127);
    }
}
