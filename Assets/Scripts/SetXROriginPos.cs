using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetXROriginPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = PlayerPositionManager.Instance.spawnPos;
        gameObject.transform.rotation = PlayerPositionManager.Instance.spawnRot;

    }

}
