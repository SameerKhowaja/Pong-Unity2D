using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public KeyCode moveU, moveD;
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 move;
    

    // Update is called once per frame
    void Update()
    {
        move.x = 0f;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(moveU))
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.fixedDeltaTime);
        }
        else if (Input.GetKey(moveD))
        {
            rb.MovePosition(rb.position + Vector2.down * speed * Time.fixedDeltaTime);
        }
        else
        {
            rb.MovePosition(rb.position + move * 0 * Time.fixedDeltaTime);
        }
        //rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }

}
