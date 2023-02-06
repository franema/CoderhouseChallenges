using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedArcher : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool isMoving;

    void Update()
    {
        isMoving = Input.GetAxis("Vertical") != 0 ;

        if (isMoving && Input.GetKey(KeyCode.LeftShift))
        {
            ManageAnimations(2);
        }
        else if (isMoving)
        {
            ManageAnimations(1);
        }
        else
        {
            ManageAnimations(0);
        }
    }

    public void ManageAnimations(float speed)
    {
        animator.SetFloat("Speed", speed);
    }
}
