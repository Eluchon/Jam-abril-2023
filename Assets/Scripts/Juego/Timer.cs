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
    private bool corutinas;
    public static float diff = 1f;
    public TextMeshProUGUI derrotaText;
    
    private void Start()
    {
        corutinas = true;
    }

    void Update()
    {
      
      if(Instance.play == true)
      {
        if  (corutinas == true)
        {
          gameObject.SendMessage("Stop");
          corutinas = false;
        }
        
        if(timer > 0)
        {
        timer -= (Time.deltaTime * diff);
        timerText.text = "" + timer.ToString("f1");
        }
        if(timer <= 0)
        {
                Instance.play=false; 
                Instance.Derrota = true;
                derrotaText.text = "SE TE QUEMARON LAS MILANGAS GIL. ¡HICISTE " + MilanesaCount.points.ToString() + " MILANESAS!";
        }
      }
        if (Instance.Menu == true)
        {
            timer = 5;
        }


    }
}
