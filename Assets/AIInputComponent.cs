using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIInputComponent : MonoBehaviour, IGetInput
{

    public MovementController movementController;

    public bool ItemInput()
    {
        return false;
    }

    public bool JumpInput()
    {
        return false;
    }

    public Vector2 MovementVector()
    {
        return new Vector2(-1, -1);
    }

}
