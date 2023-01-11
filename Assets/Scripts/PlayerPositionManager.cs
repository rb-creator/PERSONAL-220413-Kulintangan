using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionManager : MonoBehaviour
{
    public bool firstLoad;
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

    // Start is called before the first frame update
    void Start()
    {
        if (firstLoad == true)
        {
            Debug.Log("This is the FIRST time loading this scene");
        }
        else
        {
            Debug.Log("This is NOT the first time loading this scene");
        }
    }
}
