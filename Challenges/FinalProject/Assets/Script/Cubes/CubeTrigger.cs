using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    public event Action onTriggerActivated;
    void OnTriggerEnter(Collider other)
    {
        onTriggerActivated?.Invoke();
    }
}
