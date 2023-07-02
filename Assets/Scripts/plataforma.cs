using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public float jumpForce = 10;

    void OnCollisionEnter2D(Collision2D collision) {

        if(collision.relativeVelocity.y <= 0){
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if(rb != null){
            Vector2 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;
        } 
    }
    }
}
