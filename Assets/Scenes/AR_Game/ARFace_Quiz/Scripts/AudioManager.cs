using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource _audio;

    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    public void PlayeSound(AudioClip clip)
    {
        _audio.PlayOneShot(clip);
    }
}
