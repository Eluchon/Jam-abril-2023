using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    public int countdownTime;
    public TextMeshProUGUI countdownDisplay;

    private void Start() 
    {
        StartCoroutine(CountdownToStart());
    }
    // Update is called once per frame
    IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownDisplay.text = "GO!";
        
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        Instance.play=true;
    }
}
