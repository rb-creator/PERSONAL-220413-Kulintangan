using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public float movementSpeed = 50f;
    public float rotateSpeed = 20f;

    public Rigidbody rocketBody;

    public GameObject laserPrefab;
    public Transform spawnPoint;
    public float shootForce = 200f; 

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //Apply forward force to object
            rocketBody.AddForce(transform.forward * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //Apply forward backward to object
            rocketBody.AddForce(transform.forward * Time.deltaTime * movementSpeed * -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Apply force left to object
            rocketBody.AddForce(transform.right * Time.deltaTime * movementSpeed * -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Apply force right to object
            rocketBody.AddForce(transform.right * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            //Apply anticlockwise roll torque to the rocket
            rocketBody.AddTorque(0, 0, rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            //Apply clockwise roll torque to the rocket
            rocketBody.AddTorque(0, 0, rotateSpeed * Time.deltaTime *-1);
        }
        
        //When WASD keys are not being pressed, rocket will decelerate
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)) 
            {
            //slow down rocket movement to as stop
            rocketBody.velocity = rocketBody.velocity * 0.99f;
        }
         

        float horizontalRotation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");

        //Debug.Log("X : " + horizontalRotation + " " + "Y: " + verticalRotation);

        if (horizontalRotation == 0 && verticalRotation == 0)
        {
             rocketBody.angularVelocity = rocketBody.angularVelocity * 0.9f;
        }

        //Only apply  torque if right click is pressed and held
        if (Input.GetMouseButton(1))
        {
            //Get axis input and apply torque
            rocketBody.AddTorque(verticalRotation * Time.deltaTime * rotateSpeed, horizontalRotation * Time.deltaTime * rotateSpeed, 0);
        } 

        //Left Mouseclick shoots laser
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {  
            GameObject tempLaser = Instantiate(laserPrefab, spawnPoint.position, spawnPoint.rotation);
            tempLaser.GetComponent<Rigidbody>().AddForce(shootForce * spawnPoint.forward);
        }




    }
}

