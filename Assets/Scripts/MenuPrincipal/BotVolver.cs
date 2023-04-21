using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BotVolver : MonoBehaviour
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
    public GameObject botonSilenciar;
    
        public void Boton()
        {
            boton.gameObject.SetActive(true);
            logo.gameObject.SetActive(true);
            BotonMusica.gameObject.SetActive(true);
            BotonHimno.gameObject.SetActive(false);
            BotonMuchachosIns.gameObject.SetActive(false);
            BotonAtras.gameObject.SetActive(false);
            BotonMuchachosVoc.gameObject.SetActive(false);
            BotonSabalero.gameObject.SetActive(false);
            pizarra.gameObject.SetActive(false);
        botonSilenciar.gameObject.SetActive(false);
        }
    
}
