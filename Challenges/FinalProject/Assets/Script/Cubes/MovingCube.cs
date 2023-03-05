using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : Cube
{
    [SerializeField] protected MovingCubeData movingCubeData;
    private float timer;
    private float directionInverter = 1;

    private void Start() 
    {
       onReachedWall +=  OnReachedWallHandler;
    }
    private void Update()
    {
        Move(movingCubeData.speed, directionInverter);
        changeDirection(gameObject.transform.position.z);
    }

    private void OnReachedWallHandler(float inverter)
    {
        if (Time.time > timer + 0.5)
        {   
            timer = Time.time;
            directionInverter *= inverter;
        }
    }
}
