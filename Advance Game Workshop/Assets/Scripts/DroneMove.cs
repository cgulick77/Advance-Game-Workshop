using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMove : MonoBehaviour
{
    public GameObject[] patrolPoints;
    int currentPP = 0;
   
    public float speed;
    public float rSpeed = 10.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Vector3.Distance(transform.position, patrolPoints[currentPP].transform.position) < 2)
       {
            currentPP++;
       }

       if (currentPP >= patrolPoints.Length)
       {
            currentPP = 0;
       }
       
       Quaternion lookatPP = Quaternion.LookRotation(patrolPoints[currentPP].transform.position - transform.position);
       transform.rotation = Quaternion.Slerp(transform.rotation, lookatPP, rSpeed * Time.deltaTime);

       transform.Translate(0,0,speed * Time.deltaTime);
        
    }

   
}
