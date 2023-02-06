using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    private float rotationSpeed = 100;


    void Update()
    {
        Move();
        if(!Input.anyKey)
        {
            speed = 0;
        }
    }

    public void Move()
    {
        var vertical = Input.GetAxisRaw("Vertical");
        var horizontal = Input.GetAxisRaw("Horizontal");
        var rotation = new Vector3(0, horizontal, 0);
        if(Input.GetKey(KeyCode.LeftShift)) 
        {
            speed = 4;
        } else 
        {
            speed = 1;
        }

        transform.position += transform.forward * speed * Time.deltaTime * vertical;
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }

    
}
