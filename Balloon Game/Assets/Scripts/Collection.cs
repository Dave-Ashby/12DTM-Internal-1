using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    // Point value variable
    public int pointValue;

    // Game Manager
    private GameManager gameManager;
    private SpawnManager spawnManager;

    public bool collectedAlready;

    // Start is called before the first frame update
    void Start()
    {
        // Define what gameManager is
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        spawnManager = GameObject.Find("Game Manager").GetComponent<SpawnManager>();

        collectedAlready = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Detect collisions with the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (collectedAlready == false)
            {
                gameManager.UpdateScore(pointValue);
                spawnManager.UpdateTracker(1);
                // Change the state of the boolean to avoid double collecting
                collectedAlready = true;
            }
        }
        
    }
    // Change the state of the boolean back so the next money can be collected
    private void OnTriggerExit(Collider Player)
    {
        collectedAlready = false;
    }
}
