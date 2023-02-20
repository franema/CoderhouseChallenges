using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    [SerializeField] private Animator leverAnimator;
    [SerializeField] private Animator doorAnimator;
    private bool isOpen = false;

    public void Activate()
    {
        isOpen = !isOpen;
        leverAnimator.SetBool("LeverIsUp", isOpen);
        doorAnimator.SetBool("DoorIsOpen", isOpen);
    }
}
