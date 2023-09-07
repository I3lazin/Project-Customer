using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(InputHandler3D))]
public class Movement3D : MonoBehaviour
{
    // visible in Unity but still private vars
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpForce;

    private bool jumpPressed;
    private InputHandler3D playerInput;
    private Rigidbody rb;

    private void Awake()
    {
        playerInput = GetComponent<InputHandler3D>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
        if (playerInput.jumpInput && Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 1.1f))
        {
            jumpPressed = true;
        }
    }

    void FixedUpdate()
    {
        Move();
        if (jumpPressed) { Jump(); jumpPressed = false; }
    }

    private void Move()
    {
        rb.AddForce(playerInput.movementInput * speed, ForceMode.Impulse);
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, (transform.position + (Vector3.down * 1.1f)));
    }
}
