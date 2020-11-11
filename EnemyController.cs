using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform moveSpot;
    
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    void Start () {
        waitTime = startWaitTime;
        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    } // Start function

    void Update () {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f) {
            if (waitTime <= 0) {
                moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                waitTime = startWaitTime;
            } // if
            else {
                waitTime -= Time.deltaTime;
            } // else
        } // if
    } // Update function
} // EnemyController class