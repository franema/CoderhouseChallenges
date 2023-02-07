using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    [SerializeField] private Animator leverAnimator;
    [SerializeField] private Animator doorAnimator;
    private bool isOpen = false;
    
    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;
            leverAnimator.SetBool("LeverIsUp", isOpen);
            doorAnimator.SetBool("DoorIsOpen", isOpen);
            
        }
    }
}
