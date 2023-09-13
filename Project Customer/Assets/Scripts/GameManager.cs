using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dictionary<string, bool> bools = new Dictionary<string, bool>();

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
        Cursor.lockState = CursorLockMode.Locked;
    }
}
