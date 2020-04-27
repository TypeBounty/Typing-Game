using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumWordInput : MonoBehaviour
{
    public NumWordManager wordManager;

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
