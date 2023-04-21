using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuMusica : MonoBehaviour
{
    public GameObject boton;
    public GameObject logo;
    public GameObject BotonMusica;
    public GameObject BotonMuchachosIns;
    public GameObject BotonHimno;
    public GameObject BotonSabalero;
    public GameObject BotonMuchachosVoc;
    public GameObject BotonAtras;
    public TextMeshProUGUI pizarra;
    public GameObject Sabalero;
    public GameObject Muchachos;
    public GameObject himno;
    public GameObject botonsilenciar;

    public void Start()
    {
        BotonMuchachosIns.gameObject.SetActive(false);
        BotonHimno.gameObject.SetActive(false);
        BotonAtras.gameObject.SetActive(false);
        BotonMuchachosVoc.gameObject.SetActive(false);
        BotonSabalero.gameObject.SetActive(false);
        pizarra.gameObject.SetActive(false);
        Sabalero.gameObject.SetActive(false);
        Muchachos.gameObject.SetActive(false);
        himno.gameObject.SetActive(false);
        botonsilenciar.gameObject.SetActive(false);
    }
    public void Boton()
    {
        boton.gameObject.SetActive(false);
        logo.gameObject.SetActive(false);
        BotonMusica.gameObject.SetActive(false);
        BotonHimno.gameObject.SetActive(true);
        BotonMuchachosIns.gameObject.SetActive(true);
        BotonAtras.gameObject.SetActive(true);
        BotonMuchachosVoc.gameObject.SetActive(true);
        BotonSabalero.gameObject.SetActive(true);
        pizarra.gameObject.SetActive(true);
        botonsilenciar.gameObject.SetActive(true);
    }



}
