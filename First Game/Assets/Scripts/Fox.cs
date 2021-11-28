using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : Animal
{
    protected override void Jump()
    {
        jumpForce *= 1.5f;
        base.Jump();
    }
}
