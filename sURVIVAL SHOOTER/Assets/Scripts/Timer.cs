﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private int minutes;
    [SerializeField]
    private int seconds;

    private int m, s;
    [SerializeField]
    private Text timerText;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startTimer()
    {
        m = minutes;
        s = seconds;
        writeTimer(m, s);
        Invoke("updateTimer", 1f);

    }
    public void stopTimer()
    {
        CancelInvoke();
    }
    private void updateTimer()
    {
        s--;
        if (s <= 0)
        {
            if (m <= 0)
            {
                //Game Over
                gameManager.EndGame();
                return;
            }else
            {
                m--;
                s = 59;
            }

        } 
    
        writeTimer(m,s);
        Invoke("updateTimer", 1f);
    }
    private void writeTimer(int m, int s)
    {
        if (s <= 10)
        {
            timerText.text = m.ToString() + ":0" + s.ToString();
        }
        else
        {
            timerText.text = m.ToString() + ":" + s.ToString();
        }

    }

}
