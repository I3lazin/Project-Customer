using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn25D : MonoBehaviour
{
    private Rigidbody rb;

    private int checkpointNumber;

    public Vector3 startPostion;
    public GameObject checkPoint1;
    public GameObject checkPoint2;
    public GameObject checkPoint3;
    public GameObject checkPoint4;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Water")
        {
            rb.transform.position = startPostion;

            switch (checkpointNumber)
            {
                case 0: rb.transform.position = startPostion; break;
                case 1: rb.transform.position = checkPoint1.transform.position; break;
                case 2: rb.transform.position = checkPoint2.transform.position; break;
                case 3: rb.transform.position = checkPoint3.transform.position; break;
                case 4: rb.transform.position = checkPoint4.transform.position; break;
            }
        }

        //if(collision.gameObject.tag == "Checkpoint1")
        //{
        //    checkpointNumber = 1;
        //    Debug.Log("has hit checkPoint");
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.tag == "Checkpoint1")
        {
            checkpointNumber = 1;
            Debug.Log("has hit checkPoint");
        }
    }
}
