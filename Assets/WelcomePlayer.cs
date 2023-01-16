using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WelcomePlayer : MonoBehaviour
{
    private AudioSource welcomeAudio;
    public GameObject xrLocomotion;
    public TeleportationArea groundTeleportArea;
    public TeleportationAnchor firstTeleportAnchor;
    public GameObject xrLineVisual;
    public GameObject firstPointer;
    public GameObject thirdPointer;
    public GameObject fourthPointer;
    public GameObject fifthPointer;
    public bool welcomeCompleted;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPositionManager.Instance.firstLoad == true)
        {
            welcomeAudio = GetComponent<AudioSource>();
            groundTeleportArea.enabled = false;
            firstTeleportAnchor.enabled = false;
            welcomeCompleted = false;
            xrLocomotion.SetActive(false);
            xrLineVisual.SetActive(false);
            firstPointer.SetActive(false);
        }
        else
        {
            if (PlayerPositionManager.Instance.asteroidsComplete && !PlayerPositionManager.Instance.virtualInsanityComplete && !PlayerPositionManager.Instance.roomComplete)
            {
                thirdPointer.SetActive(true);
            }

            if (PlayerPositionManager.Instance.asteroidsComplete && PlayerPositionManager.Instance.virtualInsanityComplete && !PlayerPositionManager.Instance.roomComplete)
            {
                fourthPointer.SetActive(true);
            }

            if (PlayerPositionManager.Instance.asteroidsComplete && PlayerPositionManager.Instance.virtualInsanityComplete && PlayerPositionManager.Instance.roomComplete)
            {
                fifthPointer.SetActive(true);
            }

            gameObject.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (!welcomeAudio.isPlaying)
        {
            xrLocomotion.SetActive(true);
            groundTeleportArea.enabled = true;
            firstTeleportAnchor.enabled = true;
            firstPointer.SetActive(true);
            xrLineVisual.SetActive(true);
        }
        welcomeCompleted = true;
        PlayerPositionManager.Instance.firstLoad = false;
    }
}
