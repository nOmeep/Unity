﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 0.3f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0, Space.World);
    }
}
