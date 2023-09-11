using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float yRotation = 0.1f;
    void Start()
    {
        yRotation = transform.rotation.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        yRotation += Input.GetAxis("Mouse Y") * 2.0f;
        yRotation = Mathf.Clamp(yRotation, -30.0f, 45.0f);
        transform.localRotation = Quaternion.Euler(-yRotation, 0, 0);
    }
}
