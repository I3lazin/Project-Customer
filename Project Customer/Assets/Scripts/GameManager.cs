using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dictionary<string, bool> bools = new Dictionary<string, bool>();
    /* public GameObject mainMenu;*/
    public GameObject settingsCanvas;
    public GameObject achCanvas;
    public GameObject achCanvas2;
    /* public GameObject Cutscene1;*/
    public AudioSource backGround2D;
    public int timesCaught = 0;

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
        //backGround2D.PlayOneShot(backGround2D.clip);
    }

    private void Update()
    {
                if (/*mainMenu.activeInHierarchy ||*/ settingsCanvas.activeInHierarchy || achCanvas.activeInHierarchy || achCanvas2.activeInHierarchy /*|| Cutscene1.activeInHierarchy*/)
                {
                    Cursor.lockState = CursorLockMode.None;
                }
                else { Cursor.lockState = CursorLockMode.Locked; }
/*
               if ((!mainMenu.activeInHierarchy || Cutscene1.activeInHierarchy) && (mainMenu.activeInHierarchy || !Cutscene1.activeInHierarchy))
                {
                    if (!backGround2D.isPlaying)
                    {
                        backGround2D.PlayOneShot(backGround2D.clip);
                    }
                }*/
    }
}
