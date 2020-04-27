using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymWordGenerator : MonoBehaviour
{
    private static string[] wordList = { "`", "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=",
                                         "+", ";", ":", "'", "\"", "[", "{", "]", "}", ",", "<", ".", ">", "/", "?"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    } 
}
