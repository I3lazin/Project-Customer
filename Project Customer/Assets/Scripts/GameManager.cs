using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Dictionary<string, bool> bools = new Dictionary<string, bool>();
    public GameObject mainMenu = null;
    public GameObject settingsCanvas;
    public GameObject achCanvas;
    public GameObject achCanvas2;
    public GameObject Cutscene1 = null;
    public GameObject Cutscene2 = null;
    public GameObject Cutscene3 = null;
    public GameObject Credits = null;
    public AudioSource backGround2D = null;
    public int timesCaught = 0;
    private string currentSceneName;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        Collectable[] collectables = FindObjectsOfType<Collectable>();
        foreach (Collectable collectable in collectables)
        {
            bools.Add(collectable.id, false);
        }
    }

    private void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        if (currentSceneName == "Dasha")
        {
            if (mainMenu.activeInHierarchy || settingsCanvas.activeInHierarchy || achCanvas.activeInHierarchy || achCanvas2.activeInHierarchy || Cutscene1.activeInHierarchy)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else { Cursor.lockState = CursorLockMode.Locked; }

            if ((!mainMenu.activeInHierarchy || Cutscene1.activeInHierarchy) && (mainMenu.activeInHierarchy || !Cutscene1.activeInHierarchy))
            {
                if (!backGround2D.isPlaying)
                {
                    backGround2D.PlayOneShot(backGround2D.clip);
                }
            }
        }
        else
        {
            if (settingsCanvas.activeInHierarchy || achCanvas.activeInHierarchy || achCanvas2.activeInHierarchy || Cutscene2.activeInHierarchy || Cutscene3.activeInHierarchy || Credits.activeInHierarchy)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else { Cursor.lockState = CursorLockMode.Locked; }
        }
    }
}
