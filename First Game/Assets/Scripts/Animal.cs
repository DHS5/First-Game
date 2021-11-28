using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected Rigidbody animalRb;

    protected float jumpForce = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    protected virtual void Jump()
    {
        animalRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
