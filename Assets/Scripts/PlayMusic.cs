using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        //On Android  Build, set PlayDelayed to 0.4f
        //On  Windows Build, set PlayDelayed to 1.45f
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayDelayed(1.45f);
    }

   
}
