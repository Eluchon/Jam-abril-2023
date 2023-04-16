using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Libreria para manejar objetos del canva
using TMPro; //Libreria para Texto (Text Mesh Pro)

public class Timer : MonoBehaviour
{

    public static float timer = 5; //Variable global timer
    public TextMeshProUGUI timerText; // Variable de texto
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
        timer -= (Time.deltaTime * 5);
        timerText.text = "" + timer.ToString("f1");
        }

        if(timer <= 0)
        {
          Debug.Log("Se quemo la milanesa");
          timer = 0;
        }
    }
}
