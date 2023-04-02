using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStatuesLever : MonoBehaviour
{
    [SerializeField] private Animator leverAnimator;
    private bool isDown = false;
    public void MoveStatues()
    {
        if (!GameManager.instance.statuesAreMoving)
        {
            fireAnimation();
            GameManager.instance.statuesAreMoving = true;
        }
    }

    private void fireAnimation()
    {
        isDown = !isDown;
        leverAnimator.SetBool("LeverIsUp", isDown);
    }

}
