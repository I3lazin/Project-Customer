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
    [SerializeField] private float stealthMultiplier;
    [SerializeField] private float sensitivity;

    private bool isGrounded;
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
        float maximumSpeed;
        if (playerInput.sneakInput) { maximumSpeed = maxSpeed * stealthMultiplier; }
        else { maximumSpeed = maxSpeed; }


        float XZmag = Mathf.Sqrt(rb.velocity.x * rb.velocity.x + rb.velocity.z * rb.velocity.z);
        if (XZmag > maximumSpeed)
        { rb.velocity = new Vector3(rb.velocity.x / XZmag * maximumSpeed, rb.velocity.y, rb.velocity.z / XZmag * maximumSpeed); }
        if (playerInput.jumpInput && Physics.BoxCast(transform.position, new Vector3(1.75f, .2f, 2), -transform.up, transform.rotation, 1.1f))
        { jumpPressed = true; }
        transform.eulerAngles += playerInput.mouseInputX * sensitivity;
    }

    void FixedUpdate()
    {
        Move();
        if (jumpPressed) { Jump(); jumpPressed = false; }
    }

    private void Move()
    {
        rb.AddRelativeForce(playerInput.movementInput * speed, ForceMode.Impulse);
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(transform.position-transform.up*1.1f, new Vector3(1.75f, .2f, 2));
    }
}
