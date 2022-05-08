using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs;

    // Posistion of player
    public Transform player;

    // X position of when to spawn enemy
    public float chamberEntrance = 79f;
    public float chamberExit = 126.5f;

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
    }

    // Update is called once per frame
    void Update()
    {

        if ((player.position.x > chamberEntrance) && (moneyTracker < 5))
        {
            isFightingEnemies = true;
        }
        if (moneyTracker >= 5)
        {
            isFightingEnemies = false;
        }    

        while (isFightingEnemies == true)
        {
            InvokeRepeating("SpawnEnemy", 0, spawnInterval);
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefabs[0], new Vector3(102, 9, 0), enemyPrefabs[0].transform.rotation);
    }

    public void UpdateTracker(int moneyToAdd)
    {
        if (player.position.x > chamberEntrance)
        {
            moneyTracker = moneyTracker + moneyToAdd;
        }
    }
}
