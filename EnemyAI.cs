using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour {

    public Transform target;

    public float speed = 200f;
    public float nextWayPointDistance = 0.5f;

    Path path;
    int currWayPoint = 0;
    bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        seeker.StartPath(rb.position, target.position, OnPathComplete);
    } // Start function

    void OnPathComplete(Path p) {
        if (!p.error) {
            path = p;
            currWayPoint = 0;
        } // if
    } // OnPathComplete function

    void FixedUpdate() {
        if (path == null) {
            return;
        } // if

        if (currWayPoint >= path.vectorPath.Count) {
            reachedEndOfPath = true;
        } // if
        else {
            reachedEndOfPath = false;
        } // else

        Vector2 direction = ((Vector2)path.vectorPath[currWayPoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currWayPoint]);

        if (distance < nextWayPointDistance) {
            currWayPoint++;
        } // if

    } // Update function
    
}
