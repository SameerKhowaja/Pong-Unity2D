using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 vel;
    public AudioSource aud;
    
    void Start()
    {
        Invoke("gameStart", 1f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y / 1.1f) + (collision.collider.attachedRigidbody.velocity.y / 1.5f);
            rb.velocity = vel;
            aud.Play();
        }
    }

    void gameStart()
    {
        float random = Random.Range(0, 2);
        float ranY = Random.Range(0, 2); 
        if (random <= 0.5)
        {
            if (ranY <= 0.5)
            {
                rb.AddForce(new Vector2(30, -35));
            }
            else
            {
                rb.AddForce(new Vector2(30, 35));
            }
            
        }
        else
        {
            if (ranY <= 0.5)
            {
                rb.AddForce(new Vector2(-30, 35));
            }
            else
            {
                rb.AddForce(new Vector2(-30, 35));
            } 
        }

    }

    

}
