using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ball_Teleport : MonoBehaviour
{

    public float speed = 0.9f;
    public Vector3 startpos;
    public Vector3 endpos;


    // Use this for initialization
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Teleporting Ball

    void OnCollisionEnter(Collision col)

    {
        if (col.gameObject.name == "Box Floor") //When the "Ball" object collides with "Box Floor" object in Teleport_Box the Ball teleports above the ramp. 
        {
            transform.position = Vector3.Lerp(endpos, startpos, speed * Time.deltaTime);
        }
    }
}