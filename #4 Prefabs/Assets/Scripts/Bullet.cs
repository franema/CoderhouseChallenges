using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    public int damage;
    public Vector3 direction;

    void Start()
    {
    }

    void Update()
    {
        Shoot();
    }

    public void Shoot () 
    {
        transform.Translate(direction*speed);
    }
}
