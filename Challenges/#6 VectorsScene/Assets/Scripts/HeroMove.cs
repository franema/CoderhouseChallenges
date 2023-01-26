using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    [SerializeField]private float speed = 1;
    private float rotationSpeed = 100;

    void Update()
    {
        Move();
    }

    public void Move()
    {
        var vertical = Input.GetAxisRaw("Vertical");
        var horizontal = Input.GetAxisRaw("Horizontal");

        var rotation = new Vector3(0, horizontal, 0);

        transform.position += transform.forward * speed * Time.deltaTime * vertical;
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
}
