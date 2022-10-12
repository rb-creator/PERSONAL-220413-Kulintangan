using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushButton : MonoBehaviour
{
    public GameObject avatar;
    public MeshRenderer playButton;
    private MeshRenderer buttonRenderer;
    private bool isPressed = false;

    [Header("Button Transforms")]
    public Transform buttonObject;
    public Transform buttonUpPosition;
    public Transform buttonDownPosition;

    [Header("Button Events")]
    public UnityEvent OnPressed;
    //public UnityEvent OnReleased;

    
    private void Start()
    {
        buttonObject.position = buttonUpPosition.position;
        buttonRenderer = gameObject.GetComponent<MeshRenderer>();
        avatar.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && !isPressed)
        {
            //Button pressed
            buttonObject.position = buttonDownPosition.position;
            avatar.SetActive(true);
            buttonRenderer.enabled = !buttonRenderer.enabled;
            playButton.enabled = !playButton.enabled;
            isPressed = true;
      
            Invoke("DelayedStart", 0.5f);
        }
    }

    private void DelayedStart()
    {
        OnPressed?.Invoke();
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Hand"))
    //    {
    //        //Button de-pressed
    //        buttonObject.position = buttonUpPosition.position;
    //        OnReleased?.Invoke();
    //    }
    //}
}
