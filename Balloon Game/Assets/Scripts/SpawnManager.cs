using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs;

    // Posistion of player
    public Transform player;

    // X position of when to spawn enemy
    public float chamberEntrance = 79;

    public float spawnInterval = 5;

    public GameObject wall1;
    public GameObject wall2;

    public bool isFightingEnemies;
    public bool isMoneyCollected;

    private int moneyTracker;

    // Start is called before the first frame update
    void Start()
    {
        // Disable walls
        wall1.gameObject.SetActive(false);
        wall2.gameObject.SetActive(false);

        isFightingEnemies = false;

        moneyTracker = 0;
        UpdateTracker(0);

        InvokeRepeating("SpawnEnemy", 2, 8);
    }

    // Update is called once per frame
    void Update()
    {

        if ((player.position.x > chamberEntrance) && (moneyTracker < 5))
        {
            isFightingEnemies = true;
            wall1.gameObject.SetActive(true);
            wall2.gameObject.SetActive(true);
        }
        if (moneyTracker >= 5)
        {
            isFightingEnemies = false;
            wall1.gameObject.SetActive(false);
            wall2.gameObject.SetActive(false);
        }    

    }

    void SpawnEnemy()
    {
        if (isFightingEnemies == true)
        {
            Instantiate(enemyPrefabs[0], new Vector3(102, 9, 0), enemyPrefabs[0].transform.rotation);
            Debug.Log("Enemy Spawned");
        }
        
    }

    public void UpdateTracker(int moneyToAdd)
    {
        if (player.position.x > chamberEntrance)
        {
            moneyTracker = moneyTracker + moneyToAdd;
            Debug.Log("Money Collected");
        }
    }
}
