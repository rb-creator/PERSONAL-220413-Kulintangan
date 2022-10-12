using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wolf3D.ReadyPlayerMe.AvatarSDK;


public class VoiceActivator : MonoBehaviour
{
    public VoiceHandler Voice;

    //Android Build - Set Invoke delay to 0.1f
    //Windows Build - Set Invoke delay to 0.1f
    void Start()
    {
        Invoke("Play", 0.1f);
    }

   void Play()
    {
        Voice.PlayCurrentAudioClip();

    }

}
