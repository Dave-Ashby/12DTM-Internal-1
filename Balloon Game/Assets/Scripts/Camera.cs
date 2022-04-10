using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Vector3 offset;

    public Transform player;


    public float speed;
    public float delay;

    private struct PointInSpace
    {
        public Vector3 Position;
        public float Time;
    }


    private Queue<PointInSpace> pointsInSpace = new Queue<PointInSpace>();


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        pointsInSpace.Enqueue( new PointInSpace() { Position = player.position, Time = Time.time } ) ;

       while (pointsInSpace.Count > 0 && pointsInSpace.Peek().Time <= Time.time - delay + Mathf.Epsilon)
       {
         transform.position = Vector3.Lerp(transform.position, pointsInSpace.Dequeue().Position + offset, Time.deltaTime* speed);
       }
    
    }
}
