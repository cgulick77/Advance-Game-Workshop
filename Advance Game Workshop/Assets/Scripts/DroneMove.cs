using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMove : MonoBehaviour
{
    public GameObject[] patrolPoints;
    Vector3 direction;
    public float speed;
    private int x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
       
       
        
    }

    void MoveToPatrolPoint(int p)
    {
        direction = this.transform.position - patrolPoints[p].transform.position;
        this.transform.LookAt(patrolPoints[p].transform.position);
        if (direction.magnitude > .3)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
