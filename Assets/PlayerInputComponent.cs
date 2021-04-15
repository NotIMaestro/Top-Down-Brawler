using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputComponent : MonoBehaviour, IGetInput
{
    public PlayerMovement controls;

    public bool ItemInput()
    {
        return controls.Control.UsePickup.triggered;
    }

    public bool JumpInput()
    {
        return controls.Control.Jump.triggered;
    }

    public Vector2 MovementVector()
    {
        return controls.Control.ControlStick.ReadValue<Vector2>();
    }

    private void Awake()
    {
        controls = new PlayerMovement();

        controls.Enable();
    }
}
