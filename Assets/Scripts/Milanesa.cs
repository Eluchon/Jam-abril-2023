using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Milanesa : MonoBehaviour
{

    public static int cooking = 3;
    public Image milanesa;
    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {
      if(Instance.play)
      {
        if(cooking == 3)
        {
            milanesa.color = Color.red;
        }
        if(cooking == 2)
        {
            milanesa.color = Color.green;
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
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));
        } 
      }
        
    }
    public void Cooking()
    {
        cooking -= 1;
    }
}
