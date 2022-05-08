using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Variables for enemy speed
    public float horizontalForce = 10;
    public float VerticalForce = 15;

    // Rigidbody
    private Rigidbody enemyRb;
    
    // Posistions of player and enemy 
    public Transform player;
    public Transform enemy;

    // Tell the enemy when to move
    public float startAttacking = 75;
    public float stopAttacking = 126.5f;

    // Vectors for tidier code
    public Vector3 movementX;
    public Vector3 movementY;

    // Start is called before the first frame update
    void Start()
    {
        // Define the enemy rigidbody
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Enemy movement
        if ((player.position.x > startAttacking) && (player.position.x < stopAttacking))
        {
            movementX = new Vector3((player.position.x - enemy.position.x), 0, 0);
            movementY = new Vector3(0, (player.position.y - enemy.position.y), 0);
            enemyRb.AddForce(movementX.normalized * horizontalForce);
            enemyRb.AddForce(movementY.normalized * VerticalForce);
        }
        

    }

    //Stop the enemy from getting stuck
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Safe"))
        {
            enemyRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }
}
