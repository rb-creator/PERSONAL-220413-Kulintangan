using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class SavePlayerPosition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        PlayerPositionManager.Instance.spawnPos = other.transform.position;
        PlayerPositionManager.Instance.spawnRot = other.transform.rotation;
    }
}
