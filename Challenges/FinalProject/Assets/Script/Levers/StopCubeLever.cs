using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class StopCubeLever : MonoBehaviour
{
    
    [SerializeField] private ChangingCube changingCube;
    [SerializeField] private Animator leverAnimator;
    private bool isActivated = false;


    private void Start() 
    {
        GameManager.instance.onPlayerActivatedLever += OnPlayerActivatedLeverHandler;    
    }

    private void OnPlayerActivatedLeverHandler()
    {
        isActivated = !isActivated;
        leverAnimator.SetBool("LeverIsUp", isActivated);
    }
    




}
