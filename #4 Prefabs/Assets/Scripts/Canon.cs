using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public GameObject bullet;
    public Transform pointOfShoot;
    void Start()
    {
        Shoot();
    }

    void Update()
    {

    }

    public void Shoot () {
        Instantiate(bullet, pointOfShoot);
    }
}
