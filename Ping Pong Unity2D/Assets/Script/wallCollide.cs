using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCollide : MonoBehaviour
{
    public Rigidbody2D ballR;
    public Transform ballT;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Ball")
        {
            RestartGame();
        }

    }

    void ResetBall()
    {
        ballR.velocity = Vector2.zero;
        ballT.transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("gameStart", 1.5f);
    }

    void gameStart()
    {
        float random = Random.Range(0, 2);
        float ranY = Random.Range(0, 2);
        if (random <= 0.5)
        {
            if (ranY <= 0.5)
            {
                ballR.AddForce(new Vector2(30, -35));
            }
            else
            {
                ballR.AddForce(new Vector2(30, 35));
            }

        }
        else
        {
            if (ranY <= 0.5)
            {
                ballR.AddForce(new Vector2(-30, 35));
            }
            else
            {
                ballR.AddForce(new Vector2(-30, 35));
            }
        }
    }

}
