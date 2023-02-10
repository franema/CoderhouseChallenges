using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitRoom : MonoBehaviour
{

    [SerializeField] private Timer timer;

    private bool alreadyTriggered = false;

    void OnTriggerEnter(Collider other)
    {
        if (!alreadyTriggered)
        {
            timer.TimeLeft += 20;
        }
        alreadyTriggered = true;
    }
}
