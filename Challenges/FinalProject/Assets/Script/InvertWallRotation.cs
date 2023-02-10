using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertWallRotation : MonoBehaviour
{
   [SerializeField] private LookAtPlayer lookAtPlayer;

    void OnTriggerEnter(Collider other)
    {
        lookAtPlayer.isInverted = !lookAtPlayer.isInverted;
    }
}
