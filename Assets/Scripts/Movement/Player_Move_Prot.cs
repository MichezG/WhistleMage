using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Player_Move_Prot : MonoBehaviour
{

    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool isGrounded;
    public bool freeze;

    // Update is called once per frame
    void Update() {
        PlayerMove();
        PlayerRaycast();
    }

        void PlayerMove() {

        // CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded == true) {
            Jump();
        }
        //ANIMATION
        //PLAYER DIRECTION
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true) {
            FlipPlayer ();
        }
        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump() {
        //JUMPING CODE
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;

    }

    void FlipPlayer()   {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    } 

    void OnCollisionEnter2D (Collision2D col){
        //Debug.Log ("Player has collided with " + col.collider.name);
    }

    void PlayerRaycast () {
        RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.down);
        if (hit != null && hit.collider != null && hit.distance < 0.9f && hit.collider.tag == "enemy") { 
            GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 100);
        }
        if (hit != null && hit.collider != null && hit.distance < 0.9f && hit.collider.tag != "enemy") {
            isGrounded = true;
        }
    }
}
