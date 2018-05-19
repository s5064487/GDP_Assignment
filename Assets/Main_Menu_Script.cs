using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_Script : MonoBehaviour
{

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        SceneManager.LoadScene(1); //Will load the Rube Goldberg scene
    }

    public void QuitButton()
    {
        Application.Quit(); //Will end the scene
    }

    public void ResetButton()
    {
        SceneManager.LoadScene(1); //Will load the Rube Goldberg scene
    }
}    