using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PursuitHero : MonoBehaviour
{

    [SerializeField] private Transform Hero;
    [SerializeField] private float speed = 1;
    [SerializeField] private float pursuitDistance = 2;
    
    void Update()
    {
        Pursuit();
    }

    public void Pursuit()
    {
        var vectorToHero = Hero.position - transform.position;
        var distance = vectorToHero.magnitude;
        // LookAtHero();
        if (distance > pursuitDistance)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
