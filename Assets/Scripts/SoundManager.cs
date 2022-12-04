using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource audioSource;
    public AudioClip fuelSound;
    public AudioClip coinSound;

    private void Awake() => instance = this;

    // Start is called before the first frame update
    void Start() => audioSource = GetComponent<AudioSource>();
}
