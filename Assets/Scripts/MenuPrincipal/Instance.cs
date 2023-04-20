using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    public bool Menu;
    public bool play;
    public bool Derrota;
    public void Start()
    {
        
        Menu = true;
        play = false;
        Derrota = false;
    }
}
