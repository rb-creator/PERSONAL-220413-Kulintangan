using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRecord : MonoBehaviour
{

    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;
    private float speed = 75f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(target.transform.position, Vector3.up, speed * Time.deltaTime);
    }


   
}
