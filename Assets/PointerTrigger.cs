using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerTrigger : MonoBehaviour
{
    public GameObject currentPointer;
    public MeshRenderer currentMesh;
    private AudioSource guideAudio;
    public GameObject nextPointer;
    public bool hasReached;


    // Start is called before the first frame update
    void Start()
    {
        guideAudio = GetComponent<AudioSource>();
        nextPointer.SetActive(false);
        hasReached = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasReached)
        {
            StartCoroutine(PlayAndProceed());
        }
    }

    IEnumerator PlayAndProceed()
    {
        currentMesh.enabled = false;
        guideAudio.Play();
        hasReached = true;

        yield return new WaitWhile(() => guideAudio.isPlaying);
        nextPointer.SetActive(true);
    }


    private void OnTriggerExit(Collider other)
    {
        if (!guideAudio.isPlaying)
        {
            Destroy(gameObject);
            //Debug.Log("This is being destroyed");
        }
    }

}
