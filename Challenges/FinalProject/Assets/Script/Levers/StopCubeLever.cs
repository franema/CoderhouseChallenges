using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class StopCubeLever : MonoBehaviour
{
    
    [SerializeField] private ChangingCube changingCube;

    private void Start() 
    {
        GameManager.instance.onPlayerActivatedLever += OnPlayerActivatedLeverHandler;    
    }

    private void OnPlayerActivatedLeverHandler()
    {

    }
    




}
