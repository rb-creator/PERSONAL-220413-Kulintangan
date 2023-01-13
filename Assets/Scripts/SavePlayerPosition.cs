using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class SavePlayerPosition : MonoBehaviour
{
    public GameObject portal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerPositionManager.Instance.spawnPos = other.transform.position;
            PlayerPositionManager.Instance.spawnRot = other.transform.rotation;
        }

        if (portal.name == "Portal - Asteroids VR")
        {
            PlayerPositionManager.Instance.asteroidsComplete = true;
        }

        if (portal.name == "Portal - KhameleonVR")
        {
            PlayerPositionManager.Instance.virtualInsanityComplete = true;
        }

        if (portal.name == "Portal - Unity Room VR")
        {
            PlayerPositionManager.Instance.roomComplete = true;
        }
    }
}
