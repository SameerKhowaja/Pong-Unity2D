using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Text_Score ts;

    void Update()
    {
        if(ts.p1_s == 5 || ts.p2_s == 5)
        {
            if (Input.GetKey("space"))
            {
                Invoke("reload", 0.5f);
            }
        }
    }

    void reload()
    {
        SceneManager.LoadScene("lvl01");
    }

}
