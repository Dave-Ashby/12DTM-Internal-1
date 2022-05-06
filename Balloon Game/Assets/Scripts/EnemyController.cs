using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Variables:

    //Enemy speed
    public float horizontalForce = 10;
    public float VerticalForce = 15;

    //Rigidbody
    private Rigidbody enemyRb;
    
    //Posistions 
    public Transform player;
    public Transform enemy;

    //Tell the enemy when to move
    public float gate;


    public Vector3 movementX;
    public Vector3 movementY;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > gate)
        {
            movementX = new Vector3((player.position.x - enemy.position.x), 0, 0);
            movementY = new Vector3(0, (player.position.y - enemy.position.y), 0);
            enemyRb.AddForce(movementX.normalized * horizontalForce);
            enemyRb.AddForce(movementY.normalized * VerticalForce);
        }
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Safe"))
        {
            enemyRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }
}
