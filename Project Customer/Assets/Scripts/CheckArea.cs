using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckArea : MonoBehaviour
{
    [SerializeField] private LayerMask Area;
    //[SerializeField] private GameObject areaComponent;
    float range = 0.5f;
    bool hasEntredArea = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("player has entred an achievment area " + hasEntredArea);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray checkAreaRay = new Ray(transform.position, transform.TransformDirection(Vector3.down));

            //looks if a ray is hit and what it hit
            if (Physics.Raycast(checkAreaRay, out RaycastHit hitInfo, range, Area))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out ForAchievement achReqObject))
                {
                    hasEntredArea = true;
                    Debug.Log("player has entred an achievment area " + hasEntredArea);
                }
            }
        }
    }
}
