using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    // Get the position of the camera and player
    public Transform player;
    public Transform mainCamera;

    // Allow the camera to be moved
    public Rigidbody cameraRb;

    // Force applied to the camera in order to move it
    public float horizontalForce = 20f;
    public float verticalForce = 30f;

    public Vector3 cameraMovementX;
    public Vector3 cameraMovementY;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody of the camera
        cameraRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Follow the player
        //if ((player.position.x - mainCamera.position.x) > 4)
        {
            //cameraRb.AddForce(Vector3.right * horizontalForce);
        }

        //if ((mainCamera.position.x - player.position.x) > 4)
        {
            //cameraRb.AddForce(Vector3.left * horizontalForce);
        }

        //if ((player.position.y - mainCamera.position.y) > 3)
        {
            //cameraRb.AddForce(Vector3.up * verticalForce);
        }

        //if ((mainCamera.position.y - player.position.y) > 3)
        {
            //cameraRb.AddForce(Vector3.down * verticalForce);
        }





        cameraMovementX = new Vector3((player.position.x - mainCamera.position.x), 0, 0);
        cameraMovementY = new Vector3(0, (player.position.y - mainCamera.position.y), 0);


        

        if ((player.position.y - mainCamera.position.y) > 3)
        {
            cameraRb.AddForce(cameraMovementY * verticalForce);
        }
        else if ((player.position.y - mainCamera.position.y) < -3)
        {
            cameraRb.AddForce(cameraMovementY * verticalForce);
        }

        if ((player.position.x - mainCamera.position.x) > 4)
        {
            cameraRb.AddForce(cameraMovementX * horizontalForce);
        }
        else if ((player.position.x - mainCamera.position.x) < -4)
        {
            cameraRb.AddForce(cameraMovementX * horizontalForce);
        }


    }
}
