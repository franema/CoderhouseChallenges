using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody m_rigibbody;
    [SerializeField] private float speed = 0;
    private float rotationSpeed = 100;
    private float jumpForce = 5;
    private int jumpRetarder = 300;
    private int jumpBlocker = 2000;
    private bool canJump = true;


    void Update()
    {
        Move(GetMoveInput());
        Rotate(GetRotationInput());
        if (!Input.anyKey)
        {
            speed = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }


    public Vector3 GetMoveInput()
    {
        var vertical = Input.GetAxisRaw("Vertical");
        var horizontal = Input.GetAxisRaw("Horizontal");
        return new Vector3(horizontal, 0, vertical).normalized;
    }
    public void Move(Vector3 moveInput)
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 4;
        }
        else
        {
            speed = 1;
        }

        transform.position += (moveInput.z * transform.forward + moveInput.x * transform.right) * (speed * Time.deltaTime);
    }

    public void Rotate(Vector2 p_scrollDelta)
    {
        transform.Rotate(Vector3.up, p_scrollDelta.x * rotationSpeed * Time.deltaTime, Space.Self);
    }

    public Vector2 GetRotationInput()
    {
        var l_mouseX = Input.GetAxis("Mouse X");
        var l_mouseY = Input.GetAxis("Mouse Y");
        return new Vector2(l_mouseX, l_mouseY);
    }

    async System.Threading.Tasks.Task WaitMethod(int time)
    {
        await System.Threading.Tasks.Task.Delay(time);
    }
    public async void Jump()
    {
        if (canJump)
        {
            canJump = false;
            await WaitMethod(jumpRetarder);
            m_rigibbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            await WaitMethod(jumpBlocker);
            canJump = true;
        }
    }
}
