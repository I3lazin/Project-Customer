using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneSoundCon : MonoBehaviour
{
    [SerializeField] private AudioSource sceneSound;

    void Awake()
    {
        sceneSound.PlayOneShot(sceneSound.clip);
    }
}
