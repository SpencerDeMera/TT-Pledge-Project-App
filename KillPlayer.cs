// KillPlayer File
//	Author(s): Justin Galvez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {
    [SerializeField]Transform SpawnPoint;

    void OnCollisionEnter2D(Collision2D col){
        if (col.transform.CompareTag("Player")) {
            col.transform.position = SpawnPoint.position;
        } // if
    } // OnCollisionEnter2D
}
