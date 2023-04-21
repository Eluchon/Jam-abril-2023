using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    public bool Menu;
    public bool play;
    public bool Derrota;
    public bool contador;

    public void Start()
    {
        
        Menu = true;
        contador = false;
        play = false;
        Derrota = false;
    }
}
