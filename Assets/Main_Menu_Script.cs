using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("Rube Goldberg Scence");
    }
           
}
