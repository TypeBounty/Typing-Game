﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumWordTimer : MonoBehaviour
{
    public NumWordManager wordManager;

    public float wordDelay = 1.9f;
    private float nextWordTime = 2f;

    private void Update()
    {
        if (Time.time >= nextWordTime)
        {
            //wordManager.AddWord();
            nextWordTime = Time.time + wordDelay;
            //  wordDelay *= .99f;
        }
    }
}
