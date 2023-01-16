using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionManager : MonoBehaviour
{
    public bool firstLoad;
    public bool asteroidsComplete;
    public bool virtualInsanityComplete;
    public bool roomComplete;
    public Vector3 spawnPos;
    public Quaternion spawnRot;
    public static PlayerPositionManager Instance;

    private void Awake()
    {
        if (Instance !=null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
           Instance = this;
           DontDestroyOnLoad(gameObject);
        }
    }

}
