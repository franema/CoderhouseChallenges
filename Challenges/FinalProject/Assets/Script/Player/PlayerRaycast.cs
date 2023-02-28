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
            GameManager.instance.onSight = true;
            GameManager.instance.indicatorTargetTransform = raycastHitInfo.collider.transform;
            if(Input.GetKeyDown(KeyCode.E))
            {
                GameManager.instance.Activate(raycastHitInfo.collider.gameObject);
            }
        }
        else 
        {
            GameManager.instance.onSight = false;
        }

    }
}
