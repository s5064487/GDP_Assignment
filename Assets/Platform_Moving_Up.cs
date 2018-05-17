using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Platform_Moving_Up : MonoBehaviour {

    public
    Vector3 current_position;
    public float speed = 0.9f;
    public Vector3 startpos;
    public Vector3 endpos;
    // Use this for initialization
    void Start ()
    {
        current_position = this.transform.position;	
	}

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "Button");
        {
            gameObject.transform.Translate(Vector3.up * 0.125f);
        }
    }
    void Update ()
    
    {
        //gameObject.transform.Translate(Vector3.up * 0.125f);

        {
            //if (gameObject.name == "Button") ; OnCollison);
        }
    }


}
