using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Script : MonoBehaviour
{
	AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
      foreach (ContactPoint contact in collision.contacts)

        if (collision.relativeVelocity.magnitude > 1) //If there is a collision within a certain time limit (1 second) the sound wont play

                audioSource.Play(); //When the Audio Source component is added to an object with the audio track attached, that audio will play
    }
}
