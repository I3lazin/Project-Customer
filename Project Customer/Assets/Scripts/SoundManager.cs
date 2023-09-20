using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource src;
    [SerializeField] private List<string> _key = new List<string>();
    [SerializeField] private List<AudioClip> _sfx = new List<AudioClip>();
    public AudioMixer audioMixer;

    private Dictionary<string,AudioClip> sfx = new Dictionary<string,AudioClip>();

    private void Start()
    {
        for (int i = 0; i < _key.Count; ++i)
        {
            sfx.Add(_key[i], _sfx[i]);
        }
            
        foreach (KeyValuePair<string, AudioClip> pair in sfx)
        {
            Debug.Log(string.Format("Key: {0} ,Audio: {1}", pair.Key, pair.Value));
        }
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void PlaySfx(string id)
    {
        src.clip = sfx[id];
        src.Play();
        Debug.Log("Playing Sound!");
    }
}