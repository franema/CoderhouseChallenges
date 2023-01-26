using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using States;



public class ManageSoldier : MonoBehaviour
{

    [SerializeField] private SoldierStates currentState;

    void Start()
    {

    }

    void Update()
    {
        setState();
    }

    public void setState()
    {
        switch (currentState)
        { 
            case SoldierStates.Idle:
                ExecuteIdle();
                break;
            case SoldierStates.Watch:
                ExecuteWatch();
                break;
            case SoldierStates.Pursuit:
                ExecutePursuit();
                break;
        }
    }

    public void ExecuteIdle()
    {
        gameObject.GetComponent<LookAtHero>().enabled = false;
        gameObject.GetComponent<PursuitHero>().enabled = false;
    }

    public void ExecuteWatch()
    {
        gameObject.GetComponent<LookAtHero>().enabled = true;
        gameObject.GetComponent<PursuitHero>().enabled = false;
    }

    public void ExecutePursuit()
    {
        gameObject.GetComponent<LookAtHero>().enabled = true;
        gameObject.GetComponent<PursuitHero>().enabled = true;
    }
}
