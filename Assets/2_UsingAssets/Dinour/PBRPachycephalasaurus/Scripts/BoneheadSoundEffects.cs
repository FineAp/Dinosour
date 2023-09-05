using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneheadSoundEffects : MonoBehaviour
{
    //Variables

    AudioSource audioSources;


    //Sound Variants

    public AudioClip[] growlClips;

    public AudioClip[] yelpClips;

    public AudioClip[] barkClips;

    public AudioClip[] roarClips;

    public AudioClip[] deathClips;




    //Gather variables

    void Start()
    {
        // audioSource = GetComponent<AudioSource>();
    }

    public void PlayRandomSound(AudioClip[] soundClips)
    {
        if (soundClips.Length > 0)
        {
            int index = Random.Range(0, soundClips.Length);
            AudioClip clip = soundClips[index];
            // audioSource.PlayOneShot(clip);
        }
    }

    public void Growl()
    {
        PlayRandomSound(growlClips);
        
    }

    public void Yelp()
    {
        PlayRandomSound(yelpClips);
    }

    public void Bark()
    {
        PlayRandomSound(barkClips);
    }

    public void Roar()
    {
        PlayRandomSound(roarClips);
    }

    public void Death()
    {
        PlayRandomSound(deathClips);
    }

}
