using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Cube : MonoBehaviour
{
    [SerializeField] protected CubeData CubeData;
    [SerializeField] protected Transform startMark;
    [SerializeField] protected Transform endMark;
    public event Action<float> onReachedWall;
    public UnityEvent onPlayerCollided;


    public void Move(float speed, float directionInverter)
    {
        gameObject.transform.position += CubeData.direction * speed * directionInverter * Time.deltaTime;
    }

    public void changeDirection(float cubePosition)
    {
        if (cubePosition >= endMark.transform.position.z || cubePosition <= startMark.transform.position.z)
        {
            onReachedWall?.Invoke(CubeData.inverter);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Equals("Erika Archer"))
        {
            onPlayerCollided?.Invoke();
        }
    }

}
