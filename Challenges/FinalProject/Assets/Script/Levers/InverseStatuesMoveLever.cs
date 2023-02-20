using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InverseStatuesMoveLever : MonoBehaviour
{
    [SerializeField] private Animator leverAnimator;
    private bool isDown = false;
    public void InverseStatuesMove()
    {
        fireAnimation();
        if (GameManager.instance.evenOrOdd == 0)
        {
            GameManager.instance.evenOrOdd = 1;
        }
        else if (GameManager.instance.evenOrOdd == 1)
        {
            GameManager.instance.evenOrOdd = 0;
        }
    }

    private void fireAnimation ()
    {
        isDown = !isDown;
        leverAnimator.SetBool("LeverIsUp", isDown);
    }
}
