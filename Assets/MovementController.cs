using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Rigidbody rb;

    IGetInput anyInputComponent;

    public float speed = 6f;
    public GameObject capsuleMesh;

    private bool jumpTriggered;
    private Vector2 movementVector;


    public void SetInputs(bool _jumpTriggered, Vector2 _movementVector)
    {
        jumpTriggered = _jumpTriggered;
        movementVector = _movementVector;
        
    }

    // Start is called before the first frame update
    void Awake()
    {
        anyInputComponent = GetComponent<IGetInput>();
        rb = transform.GetComponent<Rigidbody>();
    }

    public void RotatePlayer(Vector2 movement)
    {
        if (movement.magnitude > 0.5f)
        {
            capsuleMesh.transform.rotation = Quaternion.LookRotation(new Vector3(movement.x, 0, movement.y), Vector3.up);

        }


    }

    // Update is called once per frame
    void Update()
    {

        SetInputs(anyInputComponent.JumpInput(), anyInputComponent.MovementVector());
        // float xDirection = Input.GetAxisRaw("Horizontal");
        // float zDirection = Input.GetAxisRaw("Vertical
        RotatePlayer(movementVector);
     

        rb.velocity = new Vector3(movementVector.x * speed, rb.velocity.y, movementVector.y * speed);

        if (jumpTriggered)
        {
            rb.velocity = new Vector3(rb.velocity.x, 10, rb.velocity.z);
        }



    }
}
