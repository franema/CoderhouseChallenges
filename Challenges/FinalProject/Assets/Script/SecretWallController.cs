using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWallController : MonoBehaviour
{
    [SerializeField] private Animator wallAnimator;

    public void OpenWall()
    {
        wallAnimator.SetBool("OpenSecretWall", true);
    }
}
