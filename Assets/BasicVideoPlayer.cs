using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicVideoPlayer : MonoBehaviour
{
    public PlayVideo screen;

    private void OnTriggerEnter(Collider other)
    {
        screen.Play();
    }
}
