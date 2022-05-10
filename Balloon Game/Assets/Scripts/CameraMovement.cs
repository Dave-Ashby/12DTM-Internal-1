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
        if (Mathf.Abs(player.position.x - mainCamera.position.x) + Mathf.Abs(player.position.y - mainCamera.position.y) > 1.5f)
        {
            cameraRb.AddForce(player.transform.position - transform.position);
        }
    }
}
