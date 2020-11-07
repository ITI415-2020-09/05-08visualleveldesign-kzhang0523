using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudio : MonoBehaviour
{
    public AudioClip splashSound;

    public AudioSource audioS;

    public AudioMixerSnapshot mainSnapshot;
    public AudioMixerSnapshot altSnapshot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        if (other.CompareTag("Interior"))
        {
            altSnapshot.TransitionTo(0.5f);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        if (other.CompareTag("Interior"))
        {
            mainSnapshot.TransitionTo(0.5f);
        }
    }
}
