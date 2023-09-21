 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    public GameObject settingsCanvas;
    public GameObject mainCanvas;
    public GameObject player;
    public GameObject pauseCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            settingsCanvas.SetActive(true);
            mainCanvas.SetActive(false);
            player.SetActive(false);
            pauseCamera.SetActive(true);
        }
    }
}
