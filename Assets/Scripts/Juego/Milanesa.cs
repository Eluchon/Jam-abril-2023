using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Milanesa : MonoBehaviour
{

    public static int cooking = 3;
    public Image milanesa;
    public AudioClip clip;
    public Instance Instance;
    public Sprite milanesaCruda;
    public Sprite milanesaCocida;
    public Sprite milanesaLista;
    [SerializeField] private GameObject particle;
    //[SerializeField] private RectTransform buttonRect; 
   

    void Update ()
    {
        if (Instance.play == true)
      {
        if(cooking == 3)
        {
            milanesa.sprite = milanesaCruda;
        }
        if(cooking == 2)
        {
            milanesa.sprite = milanesaCocida;
        }
        if(cooking == 1)
        {
            milanesa.sprite = milanesaLista;
            
        }
        if(cooking == 0)
        {
            Timer.timer = 5;
            cooking = 3;
            MilanesaCount.points += 1;
            Instantiate(particle, new Vector3(-0.22f,-0.32f,84.8f), Quaternion.identity);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));
        } 
      }
      if(Instance.Derrota == true)
        {
            milanesa.sprite = milanesaCruda;
        }
       
    }
    public void Cooking()
    {
        if(Instance.play == true)
        {
            Debug.Log("cooking");
            cooking -= 1;
        }
        
    }
}
