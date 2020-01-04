using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D ballR;
    public int score_p;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Ball")
        {
            score_p++;
        }
    }

}
