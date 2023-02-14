using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    [SerializeField] private float raycastDistance = 2f;
    [SerializeField] private LayerMask layerToCollide;


    void Update()
    {
        ManageRayCast();
    }

    private void ManageRayCast()
    {
        var hasCollided = Physics.Raycast(transform.position, transform.forward, out RaycastHit raycastHitInfo, raycastDistance, layerToCollide);
        if (hasCollided)
        {
            Debug.Log("Hola");
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Holis");
                GameManager.instance.Activate(raycastHitInfo.collider.gameObject);
            }
        }

    }
}
