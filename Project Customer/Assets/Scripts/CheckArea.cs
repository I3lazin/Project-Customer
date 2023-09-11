using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckArea : MonoBehaviour
{
    [SerializeField] private LayerMask Area;
    //[SerializeField] private GameObject areaComponent;
    float range = 3f;
    public bool hasEntredArea = false;

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
            Ray checkAreaRay = new Ray(transform.position, transform.TransformDirection(Vector3.down * range));

            //looks if a ray is hit and what it hit
            if (Physics.Raycast(checkAreaRay, out RaycastHit hitInfo, range, Area))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out ForAchievement achReqObject))
                {
                    AchievementController.ach1Count = 1;
                    hasEntredArea = true;
                    Debug.Log("player has entred an achievment area " + hasEntredArea);
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(transform.position, (transform.position + (Vector3.down * range)));
    }
}
