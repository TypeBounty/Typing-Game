using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList = { "taken", "ripe", "tough", "coding", "switch", "boring", "high", "spike", "ein", "swordfish",
                                         "direct", "help", "next", "kitana", "lobster", "milk", "squid", "torture", "guitar", "met",
                                         "chord", "chili", "quater", "basement", "replica", "shower", "fava", "tars", "vicious"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}