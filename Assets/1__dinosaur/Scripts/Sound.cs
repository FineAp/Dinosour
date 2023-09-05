using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    //Variables
    public float time = 6f;
    AudioSource audioSource;

    //Sound Variants
    public AudioClip[] growlClips;

    //Gather variables
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("PlayRandomSound", 1f, time);
    }

    public void PlayRandomSound()
    {
        if (growlClips.Length > 0)
        {
            int index = Random.Range(0, growlClips.Length);
            AudioClip clip = growlClips[index];
            audioSource.PlayOneShot(clip);
        }
    }
}
