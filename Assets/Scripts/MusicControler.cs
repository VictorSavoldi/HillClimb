using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControler : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] musics;

    // Start is called before the first frame update
    void Start()
    {
        int tracks = Random.Range(0, musics.Length);

        AudioClip musicPlay = musics[tracks];

        audioSource.clip = musicPlay;

        audioSource.Play();
    }
}
