using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransObstacle: MonoBehaviour
{

    // Use this for initialization
    void Start()
    {   Vector3 moveZ=Vector3.forward* Random.Range(-3.0f, 3.0f);
        transform.Translate(moveZ ); 
        Debug.Log("Moved Z by :"+moveZ);
        Vector3 moveX = Vector3.right * Random.Range(-3.0f, 3.0f);
        transform.Translate(moveX );
        Debug.Log("Moved X by :" + moveX);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
