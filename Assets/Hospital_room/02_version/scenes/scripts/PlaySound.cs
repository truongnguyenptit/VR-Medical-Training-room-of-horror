using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float volume;
    AudioSource audio;
    public bool isPlay = false;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent <AudioSource>();
    }

    // Update is called once per frame
     public void SoundPlay() {
        if (!isPlay) {
            audio.PlayOneShot(SoundToPlay, volume);
            isPlay = true;
        }
    }
}

