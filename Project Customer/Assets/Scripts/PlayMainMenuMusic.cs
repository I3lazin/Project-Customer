using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMainMenuMusic : MonoBehaviour
{

    [SerializeField] private AudioSource music;

    // Update is called once per frame
    void Update()
    {
        if(!music.isPlaying) { music.PlayOneShot(music.clip); }
    }
}
