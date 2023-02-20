using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatuesFloorPlates : MonoBehaviour
{
    [SerializeField] private SatuesController statuesController;

    private void OnTriggerEnter(Collider other)
    {
        statuesController.ChangeStatueState(this.transform);
    }

    private void OnTriggerExit(Collider other)
    {
        statuesController.ChangeStatueState(this.transform);
    }
}
