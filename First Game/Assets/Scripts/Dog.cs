using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    protected override void Jump()
    {
        jumpForce *= 2.0f;
        base.Jump();
    }
}
