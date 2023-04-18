using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Libreria para manejar objetos del canva
using TMPro; //Libreria para Texto (Text Mesh Pro)

public class Timer : MonoBehaviour
{

    public static float timer = 5; //Variable global timer
    public TextMeshProUGUI timerText; // Variable de texto
    public static float diff = 3f;
    
    void Update()
    {
      
      if(Instance.play)
      {
        if(timer > 0)
        {
        timer -= (Time.deltaTime * diff);
        timerText.text = "" + timer.ToString("f1");
        }
        if(timer <= 0)
        {
          Debug.Log("Se quemo la milanesa");
          timer = 0;
        }
      }
        
      
       
    }
}
