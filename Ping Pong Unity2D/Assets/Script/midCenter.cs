﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midCenter : MonoBehaviour
{
    public Transform tf;
    
    void Update()
    {
        tf.transform.position = new Vector3(0f,0f,0f);
    }
}
