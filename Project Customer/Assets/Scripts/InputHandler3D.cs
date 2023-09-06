using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler3D : MonoBehaviour
{
    public Vector2 movementInput { get; private set; }
    public bool jumpInput { get; private set; }


    void Update()
    {
        movementInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        jumpInput = Input.GetKeyDown(KeyCode.Space);
    }
}
