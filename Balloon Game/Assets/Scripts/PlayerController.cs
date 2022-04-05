using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    //physics of the balloon
    private Rigidbody playerRb;
    private float gravityModifier = 1.5f;

    // Amount of force applied to the balloon
    public float horizontalForce = 25f;
    public float verticalForce = 60f;



    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
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
}