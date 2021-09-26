using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooManyJumpsInput : MonoBehaviour, IGetInput
{
    public bool UseItemInput()
    {
        return false;
    }

    public bool JumpInput()
    {
        return true;
    }

    public Vector2 MovementVector()
    {
        return new Vector2(0, 0);
    }

    public bool DropItemInput()
    {
        return false;
    }
}
