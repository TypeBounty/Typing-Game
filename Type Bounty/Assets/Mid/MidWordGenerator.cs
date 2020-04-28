using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidWordGenerator : MonoBehaviour
{
    private static string[] wordList = { "a", "s", "d", "f", "g", "h", "j", "k", "l", "as",
                                         "sad", "dash", "fall", "gas", "had", "has", "lads"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    } 
}
