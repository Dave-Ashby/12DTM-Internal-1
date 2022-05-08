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
    //public float horizontalForce = 20f;
    //public float verticalForce = 30f;
    //public float speed = 10f;


    //public Vector3 cameraMovementX;
    //public Vector3 cameraMovementY;


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
        
        //cameraMovementX = new Vector3((player.position.x - mainCamera.position.x), 0, 0);
        //cameraMovementY = new Vector3(0, (player.position.y - mainCamera.position.y), 0);
  
        if (Mathf.Abs(player.position.x - mainCamera.position.x) + Mathf.Abs(player.position.y - mainCamera.position.y) > 2)
        cameraRb.AddForce(player.transform.position - transform.position);
    }
}
