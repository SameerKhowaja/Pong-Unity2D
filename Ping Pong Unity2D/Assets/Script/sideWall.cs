using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideWall : MonoBehaviour
{
    public Rigidbody2D wall_L, wall_R;
    public Camera cam;
    
    // Update is called once per frame
    void Update()
    {
        wall_L.transform.position = new Vector3(cam.ScreenToWorldPoint(new Vector3(45f, 0f, 0f)).x - 0.5f, 0f);
        wall_R.transform.position = new Vector3(cam.ScreenToWorldPoint(new Vector3(Screen.width - 45f, 0f, 0f)).x + 0.5f, 0f, 0f);
    }

    

}
