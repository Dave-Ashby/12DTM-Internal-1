using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalForce = 10;
    public float VerticalForce = 15;

    private Rigidbody enemyRb;
    

    public Transform player;
    public Transform enemy;

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
        movementX = new Vector3((player.position.x - enemy.position.x), 0, 0);
        movementY = new Vector3(0, (player.position.y - enemy.position.y), 0);
        enemyRb.AddForce(movementX.normalized * horizontalForce);
        enemyRb.AddForce(movementY.normalized * VerticalForce);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Safe"))
        {
            enemyRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }
}
