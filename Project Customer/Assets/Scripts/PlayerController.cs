using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 1f;
    public float groundRange = 1f;

    Rigidbody rb;
    Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 move = transform.right * x + transform.forward * z;

        //transform.Translate(moveVector * speed);
        rb.AddForce(move * speed);

        if (Input.GetKey("space") && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundRange);
    }
}
