 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    public GameObject settingsCanvas;
    public GameObject mainCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            settingsCanvas.SetActive(true);
            mainCanvas.SetActive(false);
        }
    }
}
