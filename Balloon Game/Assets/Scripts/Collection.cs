using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    //Variables
    public int pointValue;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //Define what gameManager is
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect collisions with the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.UpdateScore(pointValue);
        }
    }


}
