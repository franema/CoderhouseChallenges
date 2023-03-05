using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathHandler : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    public void OnDeathHandler ()
    {
        gameObject.transform.position = respawnPoint.transform.position;
    }

}
