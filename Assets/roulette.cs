﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roulette : MonoBehaviour
{
    float rotSpeed = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10.0f;
        }
        transform.Rotate(0, 0,this.rotSpeed);
        this.rotSpeed *= 0.978f;
    }
}