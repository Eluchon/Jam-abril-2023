using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Instance Instance;
    public static float timer = 5;
    public TextMeshProUGUI timerText;
    
    void Update()
    {
      
      if(Instance.play == true)
      {
        if(timer > 0)
        {
        timer -= (Time.deltaTime * 5);
        timerText.text = "" + timer.ToString("f1");
        }
        if(timer <= 0)
        {
                Instance.play=false; 
                Instance.Derrota = true;
        }
      }
        
      
       
    }
}
