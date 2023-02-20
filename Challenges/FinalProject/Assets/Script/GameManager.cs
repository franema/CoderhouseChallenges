using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private float _timeLeft = 120;
    public float timeLeft => _timeLeft;
    private float timeToAdd = 20;
    public int evenOrOdd = 0;
    public bool statuesAreMoving = false;
    public bool openStatuesDoor = false;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void DecreaseTime()
    {
        _timeLeft -= Time.deltaTime;
    }

    public void IncreaseTime()
    {
        _timeLeft += timeToAdd;
    }

    public void SetTimerToZero()
    {
        _timeLeft = 0;
    }


    public void Activate(GameObject objectToActivate)
    {
        Debug.Log(objectToActivate.name);
        if (objectToActivate.name.Equals("LeverFinal"))
        {
            objectToActivate.GetComponent<LeverController>().Activate();
        }

        if(objectToActivate.name.Equals("LeverMoveStatues"))
        {
            objectToActivate.GetComponent<MoveStatuesLever>().MoveStatues();
        }

        if(objectToActivate.name.Equals("LeverInverseMoveStatues"))
        {
            objectToActivate.GetComponent<InverseStatuesMoveLever>().InverseStatuesMove();
        }
    }
}