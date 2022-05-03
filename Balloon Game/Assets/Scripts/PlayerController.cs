using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    //Variables for the physics of the balloon
    private Rigidbody playerRb;
    private float GravityModifier = 2.0f;

    //Variables for the amount of force applied to the balloon
    public float horizontalForce = 25f;
    public float verticalForce = 110f;



    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= GravityModifier;
        playerRb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {

        //let the balloon go up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector3.up * verticalForce);
        }


        //let the balloon go side to side
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddForce(Vector3.right * horizontalForce);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddForce(Vector3.left * horizontalForce);
        }

    }

    //Detect Collisions
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Danger"))
        {
            Debug.Log("Game Over!");

        }

    }


    //detect money
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Money"))
        {
            Destroy(other.gameObject);
        }
    }



}