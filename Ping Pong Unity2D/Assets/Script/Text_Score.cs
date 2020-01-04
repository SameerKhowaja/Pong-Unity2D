using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Score : MonoBehaviour
{
    public Text T1, T2, Win, restart;
    public score sc1, sc2;
    public int p1_s, p2_s;
    public ballMove ball;
    public Text_Score ts;
    public SpriteRenderer spr;
    public playerMove pm1, pm2;
    public AudioSource aud;
    
    void Update()
    {
        T1.text = sc1.score_p.ToString();
        p1_s = sc1.score_p;
        T2.text = sc2.score_p.ToString();
        p2_s = sc2.score_p;

        if (p1_s == 5)
        {
            Win.text = "Player 2 Wins...!";
            restart.text = "Press Spacebar to restart";
            ball.enabled = false;
            spr.enabled = false;
            pm1.enabled = false;
            pm2.enabled = false;
            aud.enabled = false;

            ts.enabled = false;
        }
        if (p2_s == 5)
        {
            Win.text = "Player 1 Wins...!";
            restart.text = "Press Spacebar to restart";
            ball.enabled = false;
            spr.enabled = false;
            pm1.enabled = false;
            pm2.enabled = false;
            aud.enabled = false;

            ts.enabled = false;
        }

    }
}
