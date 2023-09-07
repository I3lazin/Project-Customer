using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayerScript : MonoBehaviour
{

    public Transform mainCamera;

    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(mainCamera, Vector3.up);

        Vector3 targetPosition = new Vector3(mainCamera.position.x, transform.position.y, mainCamera.position.z);
        this.transform.LookAt(targetPosition);
    }
}
