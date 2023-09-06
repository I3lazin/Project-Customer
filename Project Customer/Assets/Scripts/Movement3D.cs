using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(InputHandler3D))]
public class Movement3D : MonoBehaviour
{
    // visible in Unity but still private vars
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

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

    }

    void FixedUpdate()
    {
        Move();
        if (playerInput.jumpInput && Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down),1.1f)) { Jump(); }
    }

    private void Move()
    {
        
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
