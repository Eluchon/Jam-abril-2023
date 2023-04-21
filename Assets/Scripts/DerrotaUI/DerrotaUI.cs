using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DerrotaUI : MonoBehaviour

{
    public Instance Instance;
    public GameObject Canvasjuego;
    public GameObject CanvasDerrota;
    public GameObject CanvasMenu;
    public CountDown CountDown;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Instance.Derrota == true)
        {
            Canvasjuego.gameObject.SetActive(false);
            CanvasDerrota.gameObject.SetActive(true);
        }
    }
    public void MenuPrincipal()
    {
        CanvasDerrota.gameObject.SetActive(false);
        CanvasMenu.gameObject.SetActive(true);
        Canvasjuego.gameObject.SetActive(false);
        Instance.Derrota = false;
        Instance.Menu = true;
        CountDown.countdownTime = 3;
    }
}
