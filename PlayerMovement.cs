using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public float jump;
    private Rigidbody2D rb;
    private bool isGrounded;
    
    public Animator anim;

    public void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Start(){

    }

    void Update(){
        if(Input.GetButtunDown("Jump") && isGrounded){
            rb.AddForce(Vector2.up * jump);
        }
        if(Input.GetKeyDoen(KeyCode.LeftShift)){
            anim.SetTrigger("Slide");
        }
    }

    private void OnColisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Ground")){
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.CompareTag("Ground")){
            isGrounded = false;
        }
    }
}