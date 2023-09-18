using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dictionary<string, bool> bools = new Dictionary<string, bool>();

    public GameObject settingsCanvas;
    public GameObject achCanvas;
    public GameObject achCanvas2;

    public AudioSource backGround2D;

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
        backGround2D.PlayOneShot(backGround2D.clip);
    }

    private void Update()
    {
        if (settingsCanvas.activeInHierarchy || achCanvas.activeInHierarchy || achCanvas2.activeInHierarchy)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else { Cursor.lockState = CursorLockMode.Locked; }
    }
}
