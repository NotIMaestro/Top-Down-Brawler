using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGetInput
{
    Vector2 MovementVector();
    bool JumpInput();

    bool UseItemInput();
    bool DropItemInput();


}
