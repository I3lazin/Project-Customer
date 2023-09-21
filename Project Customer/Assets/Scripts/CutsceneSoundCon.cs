using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneSoundCon : MonoBehaviour
{
    [SerializeField] private List<AudioSource> sceneSound = new List<AudioSource>();

    void Awake()
    {
        foreach (var sound in sceneSound)
        sound.PlayOneShot(sound.clip);
    }
}
