using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Colour : MonoBehaviour {


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter(Collision col)

    {
        if (col.gameObject.name == "Ball 2") //When the "Ball" object collides with "Flap 1" object in the flaps will being to change colour. 
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
