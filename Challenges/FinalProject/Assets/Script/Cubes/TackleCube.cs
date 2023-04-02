using UnityEngine;
using System;


public class TackleCube : Cube
{
    [SerializeField] protected CubeAxisData axisData;
    [SerializeField] private CubeTrigger cubeTrigger;
    [SerializeField] private Transform endPosition;
    private float speed = 50;
    private float directionInverter = -1;
    private bool isMoving = false;

    private void Start()
    {
        cubeTrigger.onTriggerActivated += OnTriggerActivatedHandler;
    }

    private void Update()
    {
        if (isMoving)
        {
            Move(speed, directionInverter, axisData.axis);
            CheckStop();
        }
    }

    private void OnTriggerActivatedHandler()
    {
        isMoving = true;
    }

    private void CheckStop()
    {
        if (axisData.axis.z != 0)
        {
            if (gameObject.transform.position.z <= endPosition.transform.position.z)
            {
                isMoving = false;
            }
        }
        if (axisData.axis.x != 0)
        {
            if (gameObject.transform.position.x <= endPosition.transform.position.x)
            {
                isMoving = false;
            }
        }
    }
}
