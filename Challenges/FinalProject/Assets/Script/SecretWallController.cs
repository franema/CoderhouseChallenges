using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWallController : MonoBehaviour
{
    [SerializeField] private Animator wallAnimator;


    private void Update() 
    {
        if(GameManager.instance.openStatuesDoor)
        {
            wallAnimator.SetBool("OpenSecretWall", true);
        }
    }
}
