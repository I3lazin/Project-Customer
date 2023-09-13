using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler3D : MonoBehaviour
{
    public Vector3 movementInput { get; private set; }
    public Vector3 mouseInputY { get; private set; }
    public Vector3 mouseInputX { get; private set; }
    public bool jumpInput { get; private set; }
    public bool sneakInput { get; private set; }


    void Update()
    {
        movementInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        mouseInputX = new Vector3(0, Input.GetAxis("Mouse X"), 0);
        mouseInputY = new Vector3(Input.GetAxis("Mouse Y"), 0, 0);
        jumpInput = Input.GetKeyDown(KeyCode.Space);
        sneakInput = Input.GetKey(KeyCode.LeftShift);
    }
}
