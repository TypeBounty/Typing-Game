﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymWordInput : MonoBehaviour
{
    public SymWordManager wordManager;

    // Update is called once per frame
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
            Debug.Log(letter);
        }
    }
}
