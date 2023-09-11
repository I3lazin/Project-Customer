using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class CheckCollision : MonoBehaviour
{
    [SerializeField] private int nextScene;
    [SerializeField] private LayerMask SceneChange;
    private Camera mainCamera;
    //private Transform player;
    float range = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        //player = GameObject.Find("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray lookRay = new Ray(transform.position, transform.TransformDirection(Vector3.forward));

            //looks if a ray is hit and what it hit
            if (Physics.Raycast(lookRay, out RaycastHit hitInfo, range, SceneChange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out SceneChange changeScene))
                {
                    SceneManager.LoadScene(nextScene);
                }
            }
        }
    }
}
