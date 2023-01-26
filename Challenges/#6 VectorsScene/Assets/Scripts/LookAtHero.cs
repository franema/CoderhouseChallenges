using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtHero : MonoBehaviour
{
    [SerializeField] private Transform Hero;
    [SerializeField] private float rotationSpeed = 2;

    void Update()
    {
        LookAtCharacter();
    }

    public void LookAtCharacter()
    {
        var vectorToHero = Hero.position - transform.position;
        var rotation = Quaternion.LookRotation(vectorToHero);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
    }
}
