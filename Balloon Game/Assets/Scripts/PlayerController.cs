using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    // Variables for the physics of the balloon
    private Rigidbody playerRb;
    private float GravityModifier = 1.5f;

    // Variables for the amount of force applied to the balloon
    public float horizontalForce = 25f;
    public float verticalForce = 70f;

    // Game Manager
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // Player variables defined
        Physics.gravity *= GravityModifier;
        playerRb = GetComponent<Rigidbody>();

        // Letting the player affect the Game Manager
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {

        // Let the balloon go up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector3.up * verticalForce);
        }


        // Let the balloon go side to side
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddForce(Vector3.right * horizontalForce);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddForce(Vector3.left * horizontalForce);
        }

    }

    // Detect Collisions
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Danger"))
        {
            enabled = false;
            gameManager.GameOver();
        }

        if (collision.gameObject.CompareTag("Win"))
        {         
            enabled = false;
            gameManager.Win();
        }

    }


    // Detect money
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Money"))
        {
            Destroy(other.gameObject);
        }
    }



}