using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Rigidbody rb;

    public PlayerMovement controls;

    public float speed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        controls = new PlayerMovement();

        controls.Enable();

        rb = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // float xDirection = Input.GetAxisRaw("Horizontal");
        // float zDirection = Input.GetAxisRaw("Vertical");

        Vector2 controlStick = controls.Control.ControlStick.ReadValue<Vector2>();

     

        rb.velocity = new Vector3(controlStick.x * speed, rb.velocity.y, controlStick.y * speed);

        bool jumpedThisFrame = controls.Control.Jump.triggered;

        if (jumpedThisFrame)
        {
            rb.velocity = new Vector3(rb.velocity.x, 10, rb.velocity.z);
        }



    }
}
