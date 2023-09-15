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

    private bool jumpPressed;
    private InputHandler3D playerInput;
    private Rigidbody rb;

    //animation
    public Animator animator;

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
        if (playerInput.jumpInput && Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 1.5f))
        { jumpPressed = true; }
        transform.eulerAngles += playerInput.mouseInputX * sensitivity;
    }

    void FixedUpdate()
    {
        Move();
        if (jumpPressed) { Jump(); jumpPressed = false; }
        animator.SetBool("JustJumped", Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 1.1f));
    }

    private void Move()
    {
        rb.AddRelativeForce(playerInput.movementInput * speed, ForceMode.Impulse);

        if(Mathf.Abs(playerInput.movementInput.z) > 0.01)
        {
            animator.SetFloat("Speed", 1);
        } else if(Mathf.Abs(playerInput.movementInput.x) > 0.01)
        {
            animator.SetFloat("Speed", 1);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        animator.SetBool("JustJumped", true);
        animator.SetBool("IsJumping", true);
        animator.SetBool("IsInAir", true);
        animator.SetBool("JustJumped", false);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision != null)
        {
            animator.SetBool("IsJumping", false);
            animator.SetBool("IsInAir", false);

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, (transform.position + (Vector3.down * 1.5f)));
    }
}
