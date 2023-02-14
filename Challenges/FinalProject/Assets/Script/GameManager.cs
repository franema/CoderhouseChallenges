using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private float _timeLeft = 120;
    public float  timeLeft => _timeLeft;
    private float timeToAdd = 20;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else 
        {
            instance = this;
        }
    }

    public void DecreaseTime ()
    {
        _timeLeft -= Time.deltaTime;
    }

    public void IncreaseTime ()
    {
        _timeLeft += timeToAdd;
    }

    public void SetTimerToZero ()
    {
        _timeLeft = 0;
    }


    public void Activate (GameObject objectToActivate)
    {
        objectToActivate.GetComponent<LeverController>().Activate();
    }
}
