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
    private bool corutinas;
    
    private void Start()
    {
        corutinas = true;
    }

    private void Update() 
    {
        if (Instance.contador == true)
        {
            canvasjuego.gameObject.SetActive(true); 
            countdownDisplay.gameObject.SetActive(true);
            if  (corutinas == true)
            {
                StartCoroutine(CountdownToStart());
                corutinas = false;
            }
        }
        
    }
    
    IEnumerator CountdownToStart()
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
            canvasjuego.gameObject.SetActive(true); 
            Instance.contador= false;
            Instance.play = true;
            countdownTime = 3;
            corutinas = true;
            
        }

    public void Stop()
    {
        StopCoroutine(CountdownToStart());
         Debug.Log("stop"   );
    }
}
