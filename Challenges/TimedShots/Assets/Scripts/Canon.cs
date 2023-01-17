using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public Bullet bullet;
    public Transform shootingPoint;
    public float timedShoots;
    private float timer;
    void Start()
    {

    }

    void Update()
    {
        autoFire();
    }

    public void Shoot () {
        Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
    }

    public void autoFire()
    {
        timer += Time.deltaTime;
        if(timer >= timedShoots) 
        {
            Shoot();
            timer = 0;
        }
    }

}
