using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWallController : MonoBehaviour
{
    [SerializeField] private Animator wallAnimator;

    public void OpenWall()
    {
        Debug.Log("Received onStatuesOrderCorrect, from StatuesController, to SecretWallController");
        wallAnimator.SetBool("OpenSecretWall", true);
    }
}
