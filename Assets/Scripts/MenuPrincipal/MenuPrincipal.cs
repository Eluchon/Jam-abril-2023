using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    public Instance Instance;
    public GameObject CanvasJuego;
    public GameObject CanvasMenu;
    public GameObject CanvasDerrota;


    void Start()
    {
        if (Instance.play == false)
        {
            if (Instance.Derrota == false) {
                CanvasJuego.gameObject.SetActive(false);
                CanvasDerrota.gameObject.SetActive(false);

            }
            
        }

    }

    public void Iniciar()
    {
        Instance.Menu = false;
        Instance.contador = true;
        CanvasMenu.gameObject.SetActive(false);
    }

}
