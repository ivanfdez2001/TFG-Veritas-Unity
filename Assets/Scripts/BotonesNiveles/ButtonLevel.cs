using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonLevel : MonoBehaviour
{
    //--------------------------------- NIVEL 1 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 1 CAMBIA A ESCENA NIVEL 1
    public void BotonLevel1()
    {
        SceneManager.LoadScene(3);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 1 CAMBIA A ESCENA NIVEL 2
    public void BotonNextLevel1()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(9);
    }

    //--------------------------------- NIVEL 2 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 2 CAMBIA A ESCENA NIVEL 2
    public void BotonLevel2()
    {
        SceneManager.LoadScene(10);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 2 CAMBIA A ESCENA NIVEL 3
    public void BotonNextLevel2()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(16);
    }

    //--------------------------------- NIVEL 3 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 3 CAMBIA A ESCENA NIVEL 3
    public void BotonLevel3()
    {
        SceneManager.LoadScene(17);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 3 CAMBIA A ESCENA NIVEL 4
    public void BotonNextLevel3()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(23);
    }

    //--------------------------------- NIVEL 4 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 4 CAMBIA A ESCENA NIVEL 4
    public void BotonLevel4()
    {
        SceneManager.LoadScene(24);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 4 CAMBIA A ESCENA NIVEL 5
    public void BotonNextLevel4()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(30);
    }

    //--------------------------------- NIVEL 5 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 5 CAMBIA A ESCENA NIVEL 5
    public void BotonLevel5()
    {
        SceneManager.LoadScene(31);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 5 CAMBIA A ESCENA NIVEL 6
    public void BotonNextLevel5()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(37);
    }

    //--------------------------------- NIVEL 6 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 6 CAMBIA A ESCENA NIVEL 6
    public void BotonLevel6()
    {
        SceneManager.LoadScene(38);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 6 CAMBIA A ESCENA NIVEL 7
    public void BotonNextLevel6()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(44);
    }

    //--------------------------------- NIVEL 7 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 7 CAMBIA A ESCENA NIVEL 7
    public void BotonLevel7()
    {
        SceneManager.LoadScene(45);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 7 CAMBIA A ESCENA NIVEL 8
    public void BotonNextLevel7()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(51);
    }

    //--------------------------------- NIVEL 8 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 8 CAMBIA A ESCENA NIVEL 8
    public void BotonLevel8()
    {
        SceneManager.LoadScene(52);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 8 CAMBIA A ESCENA NIVEL 9
    public void BotonNextLevel8()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(58);
    }

    //--------------------------------- NIVEL 9 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 9 CAMBIA A ESCENA NIVEL 9
    public void BotonLevel9()
    {
        SceneManager.LoadScene(59);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 9 CAMBIA A ESCENA NIVEL 10
    public void BotonNextLevel9()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(65);
    }

    //--------------------------------- NIVEL 10 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 10 CAMBIA A ESCENA NIVEL 10
    public void BotonLevel10()
    {
        SceneManager.LoadScene(66);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 10 CAMBIA A ESCENA NIVEL 11
    public void BotonNextLevel10()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(72);
    }

    //--------------------------------- NIVEL 11 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 11 CAMBIA A ESCENA NIVEL 11
    public void BotonLevel11()
    {
        SceneManager.LoadScene(73);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 11 CAMBIA A ESCENA NIVEL 12
    public void BotonNextLevel11()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(79);
    }

    //--------------------------------- NIVEL 12 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 12 CAMBIA A ESCENA NIVEL 12
    public void BotonLevel12()
    {
        SceneManager.LoadScene(80);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 12 CAMBIA A ESCENA NIVEL 13
    public void BotonNextLevel12()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(86);
    }

    //--------------------------------- NIVEL 13 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 13 CAMBIA A ESCENA NIVEL 13
    public void BotonLevel13()
    {
        SceneManager.LoadScene(87);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 13 CAMBIA A ESCENA NIVEL 14
    public void BotonNextLevel13()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(93);
    }

    //--------------------------------- NIVEL 14 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 14 CAMBIA A ESCENA NIVEL 14
    public void BotonLevel14()
    {
        SceneManager.LoadScene(94);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 14 CAMBIA A ESCENA NIVEL 15
    public void BotonNextLevel14()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(100);
    }

    //--------------------------------- NIVEL 15 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 15 CAMBIA A ESCENA NIVEL 15
    public void BotonLevel15()
    {
        SceneManager.LoadScene(101);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 15 CAMBIA A ESCENA NIVEL 16
    public void BotonNextLevel15()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(107);
    }

    //--------------------------------- NIVEL 16 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 16 CAMBIA A ESCENA NIVEL 16
    public void BotonLevel16()
    {
        SceneManager.LoadScene(108);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 16 CAMBIA A ESCENA NIVEL 17
    public void BotonNextLevel16()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(114);
    }

    //--------------------------------- NIVEL 17 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 17 CAMBIA A ESCENA NIVEL 17
    public void BotonLevel117()
    {
        SceneManager.LoadScene(115);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 17 CAMBIA A ESCENA NIVEL 18
    public void BotonNextLevel17()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(121);
    }

    //--------------------------------- NIVEL 18 ----------------------------------------

    // EN MENU NIVELES PULSAR BOTON NIVEL 18 CAMBIA A ESCENA NIVEL 18
    public void BotonLevel118()
    {
        SceneManager.LoadScene(122);
    }

    // PULSAR BOTON NEXT LEVEL EN NIVEL 18 CAMBIA A ESCENA MENU PRINCIPAL
    public void BotonNextLevel18()
    {
        ControladorNiveles.instancia.AumentarNiveles();
        ControladorInsignias.instancia.AumentarInsignias();
        ControladorIconoInsignias.instancia.AumentarIconoInsignias();

        SceneManager.LoadScene(127);
    }
}