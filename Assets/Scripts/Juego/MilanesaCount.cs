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
        if (instance.Menu == true)
        {
            points = 0;
        }
       
    }
}
