using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrookedMove : MonoBehaviour
{

    private float speed = 1;
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        var direction = new Vector3(horizontal, 0, vertical);
        transform.position += direction * speed * Time.deltaTime;
    }
}
