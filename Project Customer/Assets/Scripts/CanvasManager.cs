using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableCanvas()
    {
        gameObject.SetActive(false);
    }

    public void EnableCanvas(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void DisableObj(GameObject obj)
    {
        obj.SetActive(false);
    }
}
