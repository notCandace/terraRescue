﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTiles : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, 0, 0)*speed;
    }
}