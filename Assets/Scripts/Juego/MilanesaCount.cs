using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MilanesaCount : MonoBehaviour
{
    
    static public int points;
    public TextMeshProUGUI pointsText;
    public Instance instance;

    void Start()
    {
        points = 0; 
        
    }
    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Contador de Milanesas: " + points.ToString();
         if (points == 10)
        {
            Timer.diff = 2f;
        }
        if (points == 20)
        {
            Timer.diff = 3f;
        }
        if (points == 30)
        {
            Timer.diff = 4f;
        }
        if (points == 40)
        {
            Timer.diff = 5f;
        }
        if (points == 50)
        {
            Timer.diff = 6f;
        }
        if (points == 60)
        {
            Timer.diff = 6.5f;
        }
        if (points == 70)
        {
            Timer.diff = 7f;
        }
        if (points == 80)
        {
            Timer.diff = 7.5f;
        }
        if (points == 90)
        {
            Timer.diff = 8f;
        }
        if (instance.Menu == true)
        {
            points = 0;
        }
       
    }
}
