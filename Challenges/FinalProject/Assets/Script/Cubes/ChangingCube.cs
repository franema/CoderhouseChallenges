using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingCube : Cube
{
    [SerializeField] protected MovingCubeData changedCubeData;
    [SerializeField] protected MovingCubeData movingCubeData;
    private float directionInverter = 1;

    private float ownSpeed;
    private bool changed = false;
    private float timer;


    private void Start()
    {
        onReachedWall += OnReachedWallHandler;
        GameManager.instance.onPlayerActivatedLever += OnPlayerActivatedLeverHandler;
        ownSpeed = movingCubeData.speed;
    }
    private void Update()
    {
        Move(ownSpeed, directionInverter);
        changeDirection(gameObject.transform.position.z);
    }

    private void OnPlayerActivatedLeverHandler()
    {
        Debug.Log("Received onPlayerActivatedLever, from GameManager, to ChangingCube");
        if (changed)
        {
            changed = false;
            ownSpeed = movingCubeData.speed;
        }
        else
        {
            changed = true;
            ownSpeed = changedCubeData.speed;
        }
    }

    public void OnReachedWallHandler(float inverter)
    {
        if (Time.time > timer + 0.3)
        {
            timer = Time.time;
            directionInverter *= inverter;
        }
    }
}
