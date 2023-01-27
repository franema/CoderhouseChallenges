using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpWall : MonoBehaviour
{
    private Transform newTransform;
    private Vector3 newPosition;
    private Quaternion newRotation;
    private float timer;


    void OnCollisionEnter(Collision other)
    {
        timer = Time.time;
    }
    void OnCollisionStay(Collision other)
    {
        if (Time.time > timer + 2)
        {
            newPosition = new Vector3(Random.Range(-30f, 35f), Random.Range(0.1f, 1f), Random.Range(-30f, 35f));
            newRotation = new Quaternion(Random.Range(0.1f, 180), Random.Range(0.1f, 180), Random.Range(0.1f, 180), Random.Range(0.1f, 180));
            transform.position = newPosition;
            transform.rotation = newRotation;
        }
    }

}
