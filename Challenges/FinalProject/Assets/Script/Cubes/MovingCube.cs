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

    public void OnReachedWallHandler(float inverter)
    {
        Debug.Log("Received onReachedWall, from Cube, to MovingCube");
        if (Time.time > timer + 0.3)
        {   
            timer = Time.time;
            directionInverter *= inverter;
        }
    }
}
