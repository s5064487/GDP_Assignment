using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cover_Delete : MonoBehaviour {

    public GameObject Ball;
    public GameObject Cover;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Ball)
        {
            Destroy(Cover);
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
