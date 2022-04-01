using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  

    //
    private Rigidbody playerRb;

    // Amount of force applied to the balloon
    public float horizontalForce = 10;
    public float verticalForce = 50;



    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Detect Inputs
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        //let the balloon go up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector3.up * verticalForce);
        }


        //let the balloon go side to side
        if (Input.GetKey(KeyCode.RightArrow))
        {
           playerRb.AddForce(Vector3.right * horizontalForce);
           playerRb.AddTorque()
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddForce(Vector3.left * horizontalForce);
        }

    }
}
