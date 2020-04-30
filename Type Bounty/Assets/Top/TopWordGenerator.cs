using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopWordGenerator : MonoBehaviour
{
    private static string[] wordList = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p",
                                         "quiet", "quit", "quite", "were", "Europe", "ripe", "rope", "trip", "tore", "trope",
                                         "tour", "route", "yet", "up", "it", "owe", "port", "power", "pour"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    } 
}
