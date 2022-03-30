using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  

    //
    private Rigidbody playerRb;

    // Amount of force applied to the balloon
    public float horizontalForce = 5;
    public float verticalForce = 5;



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


        playerRb.AddForce(Vector3.up * verticalForce * verticalInput);
    }
}
