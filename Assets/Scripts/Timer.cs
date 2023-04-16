using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public static float timer = 10;
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= (Time.deltaTime * 2);

        timerText.text = "" + timer.ToString("f1");

        if(timer <= 0)
        {
          Debug.Log("Se quemó la milanesa");
          timer = 0;
        }
    }
}
