using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayLevelSong : MonoBehaviour {

    public AudioClip otherClip;
    AudioSource audioSource;

    void Start()
    {
        audioSource = FindObjectOfType(typeof(AudioSource)) as AudioSource;
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = otherClip;
            audioSource.Play();
        }
    }
}
