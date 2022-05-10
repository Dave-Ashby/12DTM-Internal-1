using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Variables:
    // Index for enemy spawning
    public GameObject[] enemyPrefabs;

    // Posistion of player
    public Transform player;

    // X position of when to spawn enemy
    public float chamberEntrance = 79;

    // How often the game will spawn enemies
    public float spawnInterval = 8;

    // Walls of the chamber
    public GameObject wall1;
    public GameObject wall2;

    // Booleans for for enemy fight
    public bool isFightingEnemies;
    public bool isMoneyCollected;

    // Keep track of how much money is collected
    private int moneyTracker;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the level
        wall1.gameObject.SetActive(false);
        wall2.gameObject.SetActive(false);
        isFightingEnemies = false;
        moneyTracker = 0;
        UpdateTracker(0);
        InvokeRepeating("SpawnEnemy", 2, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // Start the enemy fight
        if ((player.position.x > chamberEntrance) && (moneyTracker < 5))
        {
            isFightingEnemies = true;
            wall1.gameObject.SetActive(true);
            wall2.gameObject.SetActive(true);
        }
        // End the enemy fight
        if (moneyTracker >= 5)
        {
            isFightingEnemies = false;
            wall1.gameObject.SetActive(false);
            wall2.gameObject.SetActive(false);
        }    

    }
    // Spawn the Enemies
    void SpawnEnemy()
    {
        if (isFightingEnemies == true)
        {
            Instantiate(enemyPrefabs[0], new Vector3(102, 9, 0), enemyPrefabs[0].transform.rotation);
            Debug.Log("Enemy Spawned");
        }
        
    }
    // Count how much money the player has collected in order to clear the room
    public void UpdateTracker(int moneyToAdd)
    {
        if (player.position.x > chamberEntrance)
        {
            moneyTracker = moneyTracker + moneyToAdd;
        }
    }
}
