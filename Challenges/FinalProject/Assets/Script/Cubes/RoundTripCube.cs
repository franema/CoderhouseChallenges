using UnityEngine;
using System;

public class RoundTripCube : Cube
{
    [SerializeField] protected Transform startMark;
    [SerializeField] protected Transform endMark;
    public event Action<float> onReachedWall;
    private float inverter = -1;


    

    public void changeDirection(float cubePosition)
    {
        if (cubePosition >= endMark.transform.position.z || cubePosition <= startMark.transform.position.z)
        {
            onReachedWall?.Invoke(inverter);
        }
    }

    

}
