using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour {

    static bool AudioBegin = false;

    void Awake() {
        if (!AudioBegin) {
            // audio.Play();
            DontDestroyOnLoad(transform.gameObject);
            AudioBegin = true;
        } // if
    } // Awake function

    void Update () {
        if (Application.loadedLevelName == "MainMenu") {
            Destroy(this.gameObject);
            AudioBegin = false;
        } // else
    } // Update function

} // DontDestroyAudio function
