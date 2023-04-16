using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public static float timer = 5;
    public TextMeshProUGUI timerText;
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
