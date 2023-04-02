using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    // [SerializeField] public float TimeLeft;
    private bool TimerOn = false;
    [SerializeField] private TMP_Text TimerText;
    [SerializeField] private Image panel;
    public event Action onTimeOver;


    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if (TimerOn)
        {
            if (GameManager.instance.timeLeft > 0)
            {
                GameManager.instance.DecreaseTime();
                UpdateTimer(GameManager.instance.timeLeft);
            }
            else
            {
                onTimeOver?.Invoke();
                GameManager.instance.SetTimerToZero();
                TimerOn = false;
            }

            SetPanelColor();

           
        }
    }

    private void UpdateTimer(float CurrentTime)
    {
        CurrentTime += 1;

        float minutes = Mathf.FloorToInt(CurrentTime / 60);
        float seconds = Mathf.FloorToInt(CurrentTime % 60);

        TimerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    private void SetPanelColor()
    {
        switch (GameManager.instance.timeLeft)
        {
            case > 40:
                panel.color = Color.green;
                break;
            case > 20:
                panel.color = Color.yellow;
                break;
            case < 20:
                panel.color = Color.red;
                break;
        }
    }
}
