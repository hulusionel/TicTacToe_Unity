using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLeft : MonoBehaviour {

    Image timerBar;
    public float maxtime = 3f;
    float timeLeft;   
    public Image timeOver;


    public void Start ()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxtime;        
    }

    public void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;           
            timerBar.fillAmount = timeLeft / maxtime;
        }
        else
        {
            Time.timeScale = 0;
            timeOver.gameObject.SetActive(true);
            
        }
        
    }
}
