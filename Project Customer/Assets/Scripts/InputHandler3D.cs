using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler3D : MonoBehaviour
{
    public Vector3 movementInput { get; private set; }
    public bool jumpInput { get; private set; }


    void Update()
    {
        movementInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        jumpInput = Input.GetKeyDown(KeyCode.Space);
    }
}
