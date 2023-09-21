using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public new Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("camera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camera);

        Vector3 targetPosition = new Vector3(camera.position.x, transform.position.y, camera.position.z);
        this.transform.LookAt(targetPosition);
    }
}
