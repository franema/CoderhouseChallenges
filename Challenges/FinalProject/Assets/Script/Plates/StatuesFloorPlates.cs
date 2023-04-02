using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatuesFloorPlates : MonoBehaviour
{
    [SerializeField] private SatuesController statuesController;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        statuesController.ChangeStatueState(this.transform, false);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        statuesController.ChangeStatueState(this.transform, true);
    }
}
