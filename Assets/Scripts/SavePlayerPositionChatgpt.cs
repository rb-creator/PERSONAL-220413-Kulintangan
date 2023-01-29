using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPositionChatgpt : MonoBehaviour
{
    public GameObject portal;
    private readonly Dictionary<string, System.Action> portalActions = new Dictionary<string, System.Action>()
{
{"Portal - Asteroids VR", () => PlayerPositionManager.Instance.asteroidsComplete = true },
{"Portal - KhameleonVR", () => PlayerPositionManager.Instance.virtualInsanityComplete = true },
{"Portal - Unity Room VR", () => PlayerPositionManager.Instance.roomComplete = true }
};

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerPositionManager.Instance.spawnPos = other.transform.position;
            PlayerPositionManager.Instance.spawnRot = other.transform.rotation;
        }

        if (portalActions.TryGetValue(portal.name, out System.Action action))
        {
            action();
        }
    }
}
