using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Milanesa : MonoBehaviour
{

    public static int cooking = 3;
    public Image milanesa;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cooking == 3)
        {
            milanesa.color = Color.red;
        }
        if(cooking == 2)
        {
            milanesa.color = Color.yellow;
        }
        if(cooking == 1)
        {
            milanesa.color = Color.white;
            
        }
        if(cooking == 0)
        {
            Timer.timer = 5;
            cooking = 3;
            MilanesaCount.points += 1;
        }
        
    }
    public void Cooking()
    {
        cooking -= 1;
    }
}
