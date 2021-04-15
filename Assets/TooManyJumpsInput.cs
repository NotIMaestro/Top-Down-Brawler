using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooManyJumpsInput : MonoBehaviour, IGetInput
{
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
        return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }

}
