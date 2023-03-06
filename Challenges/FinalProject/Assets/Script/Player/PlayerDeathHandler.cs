using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathHandler : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    public void OnDeathHandler ()
    {
        Debug.Log("Received onDeath, from Cube, to PlayerDeathHandler");
        gameObject.transform.position = respawnPoint.transform.position;
    }

}
