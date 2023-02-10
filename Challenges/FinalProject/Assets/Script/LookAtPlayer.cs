using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float rotationSpeed = 2;
    public bool isActive = true;
    public bool isInverted = false;

    void Update()
    {
        if (isActive)
        {
            LookAtCharacter();
        }
    }

    public void LookAtCharacter()
    {
        var vectorToPlayer = player.position - transform.position;
        vectorToPlayer.y = 0;
        var rotation = Quaternion.LookRotation(vectorToPlayer);
        if (isInverted)
        {
            rotation = Quaternion.Inverse(rotation);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
    }

}
