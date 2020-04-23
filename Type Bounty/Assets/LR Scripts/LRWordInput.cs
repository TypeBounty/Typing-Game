using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRWordInput : MonoBehaviour
{
    public LRWordManager wordManager;


    // Update is called once per frame
    void Update()
    {
        foreach(char letter in Input.inputString)
        {
            Debug.Log(letter);
            wordManager.TypeLetter(letter);
        }
    }
}
