using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
    
    public int countdownTime;
    public TextMeshProUGUI countdownDisplay;
    public Instance Instance;
    public GameObject canvasjuego;



    
    

    private void Update() 
    {
        if (Instance.Menu == false)
        {
            if (Instance.Derrota == false)
            {
                canvasjuego.gameObject.SetActive(true);
                if (Instance.play == false)
                {
                    StartCoroutine(Coroutine());
                    
                }
            }
        }
       
        IEnumerator Coroutine()
        {
            
            while (countdownTime > 0)
            {
                countdownDisplay.text = countdownTime.ToString();
                yield return new WaitForSeconds(1f);
                countdownTime--;
            }

            countdownDisplay.text = "GO!";

            yield return new WaitForSeconds(1f);
            countdownDisplay.gameObject.SetActive(false);
            Instance.play = true;
            
        }
    }
    
   
}
