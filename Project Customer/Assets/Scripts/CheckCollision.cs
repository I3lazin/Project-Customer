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
    int range = 4;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray gunRay = new Ray(mainCamera.transform.position, mainCamera.transform.forward);

            //looks if a ray is hit and what it hit
            if (Physics.Raycast(gunRay, out RaycastHit hitInfo, range, SceneChange))
            {

                if (hitInfo.collider.gameObject.TryGetComponent(out SceneChange buyEnd))
                {
                    SceneManager.LoadScene(nextScene);
                }
            }
        }
    }
}
