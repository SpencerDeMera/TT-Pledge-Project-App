using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour {

    public void LoadMenu() {
        SceneManager.LoadScene("MainMenu");
    } // LoadMenu function 

    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    } // QuitGame function
} // EndMenu class
