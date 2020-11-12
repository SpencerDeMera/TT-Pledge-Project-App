using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;
    public float runSpeed = 25f;
    bool jump = false;

    // Update is called once per frame
    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump")) {
            jump = true;
            animator.SetBool("IsJump", true);
        } // if
    } // Update

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Coins")) {
            Destroy(other.gameObject);
        } // if
    } // OnTriggerEnter function

    public void OnLanding () {
        animator.SetBool("IsJump", false);
    } // OnLanding function

    void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    } // FixedUpdate function
} // PlayerMovement class
