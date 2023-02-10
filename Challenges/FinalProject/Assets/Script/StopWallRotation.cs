using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWallRotation : MonoBehaviour
{
    [SerializeField] private LookAtPlayer lookAtPlayer;
    void OnTriggerEnter(Collider other)
    {
        lookAtPlayer.isActive = !lookAtPlayer.isActive;
    }

    void OnTriggerExit(Collider other)
    {
        lookAtPlayer.isActive = !lookAtPlayer.isActive;
    }
}
