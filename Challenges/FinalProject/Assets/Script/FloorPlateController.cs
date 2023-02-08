using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPlateController : MonoBehaviour
{
  [SerializeField] private Animator smallDoorAnimator;


  void OnTriggerStay(Collider other)
  {
    smallDoorAnimator.SetBool("SmallDoorIsOpen", true);
  }

  void OnTriggerExit(Collider other)
  {
    smallDoorAnimator.SetBool("SmallDoorIsOpen", false);
  }
}
