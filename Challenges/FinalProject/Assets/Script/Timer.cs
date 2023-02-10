using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] public float TimeLeft;
    private bool TimerOn = false;
    [SerializeField] private TMP_Text TimerText;
    [SerializeField] private Image panel;

    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                UpdateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Time is Up!");
                TimeLeft = 0;
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
        switch (TimeLeft)
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
