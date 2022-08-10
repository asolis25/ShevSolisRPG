using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // X axis movement
        movement.x = Input.GetAxisRaw("Horizontal");

        // Y axis movement
        movement.y = Input.GetAxisRaw("Vertical");

        // Combined normalized movement vector
        movement = new Vector2(movement.x, movement.y).normalized;

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
  
    }

    private void FixedUpdate()
    {
        //  Moves player according to given inputs
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }

    void onCollisionEnter2D(Collision2D collision){
        Debug.Log("trigger test");
        
    }

    
}
