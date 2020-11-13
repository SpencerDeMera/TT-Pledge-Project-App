// PlayerEndGame File
//	Author(s): Spencer DeMera

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEndGame : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D death) {
        if (death.gameObject.CompareTag("EndMenu")) {
            SceneManager.LoadScene("EndMenu");
        } // if
    } // OnTriggerEnter function
} // PlayerEndGame class
