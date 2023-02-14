using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedArcher : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool isMoving;
    private bool isCrouched = false;
    private bool canJump = true;
    private int jumpBlocker = 2300;

    void Update()
    {
        isMoving = Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0;

        SetSpeed();
        SetJump();
        SetCrouch();
        SetSideWalk();

        
    }

    private void ManageSpeed(float speed)
    {
        animator.SetFloat("Speed", speed);
    }

    private void SetSpeed ()
    {
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
    }

    async System.Threading.Tasks.Task WaitMethod(int time)
    {
        await System.Threading.Tasks.Task.Delay(time);
    }
    private async void SetJump () 
    {
        if(Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            animator.SetTrigger("Jump");
            await WaitMethod(jumpBlocker);
            canJump = true;
        }
    }

    private void SetCrouch ()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouched = !isCrouched;
            animator.SetBool("Crouch", isCrouched);
        }
    }

    private void SetSideWalk()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            animator.SetBool("GoingRight", true);
        } 
        else if(Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("GoingLeft", true);
        }
        else 
        {
            animator.SetBool("GoingRight", false);
            animator.SetBool("GoingLeft", false);
        }
    }
}
