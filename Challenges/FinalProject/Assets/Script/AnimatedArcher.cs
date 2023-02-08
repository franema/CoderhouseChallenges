using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedArcher : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool isMoving;

    private bool isCrouched = false;

    void Update()
    {
        isMoving = Input.GetAxis("Vertical") != 0 ;

        if (isMoving && Input.GetKey(KeyCode.LeftShift))
        {
            ManageSpeed(2);
        }
        else if (isMoving)
        {
            ManageSpeed(1);
        }
        else
        {
            ManageSpeed(0);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouched = !isCrouched;
            animator.SetBool("Crouch", isCrouched);
        }
    }

    public void ManageSpeed(float speed)
    {
        animator.SetFloat("Speed", speed);
    }
}
