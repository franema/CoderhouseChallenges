using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceRaycast : MonoBehaviour
{
    [SerializeField] private float raycastDistance = 15f;
    [SerializeField] private LayerMask layerToCollide;
    [SerializeField] private Animator wallAnimator;


    // Update is called once per frame
    void Update()
    {
        CreateRaycast();
        
    }

    private void CreateRaycast()
    {
        var hasCollided =  Physics.Raycast(transform.position, transform.forward, out RaycastHit raycastHitInfo, raycastDistance, layerToCollide);
        if (hasCollided && raycastHitInfo.collider.name == "WallPlate")
        {
            wallAnimator.SetBool("WallOpen", true);
        }
        else if(hasCollided && raycastHitInfo.collider.name != "WallPlate")
        {
            wallAnimator.SetBool("WallOpen", false);
        }
    }


}
