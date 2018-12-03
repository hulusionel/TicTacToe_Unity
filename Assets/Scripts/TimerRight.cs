using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerRight : MonoBehaviour
{

    Image timerBar;
    public float maxtime = 3f;
    float timeRight;
    public Image timeOver;


    public void Start()
    {
        timerBar = GetComponent<Image>();
        timeRight = maxtime;
    }

    public void Update()
    {
        if (timeRight > 0)
        {
            timeRight -= Time.deltaTime;
            timerBar.fillAmount = timeRight / maxtime;
        }
        else
        {
            Time.timeScale = 0;
            timeOver.gameObject.SetActive(true);

        }

    }
}
