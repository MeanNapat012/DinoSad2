using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jump;
    private Rigidbody2D rb;
    private bool isGrounded;
    
    public Animator anim;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)&&isGrounded == true){
            rb.AddForce(Vector3.up * jump);
        }
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            anim.SetTrigger("Slide");
        }
    }
    
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Ground")
        {
            isGrounded = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Ground")
        {
            isGrounded = false;
        }
    }

}
