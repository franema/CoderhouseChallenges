using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{


    [SerializeField] private KeyCode shootKeyCode;
    public GameObject ball;
    public Transform pointOfShoot;







    private void Update()
    {
        if (Input.GetKeyDown(shootKeyCode))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(ball, pointOfShoot);
        Debug.Log("Shoot");
    }



}
