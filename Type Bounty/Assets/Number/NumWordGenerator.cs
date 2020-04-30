using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumWordGenerator : MonoBehaviour
{
    private static string[] wordList = { "1","32","22","985","700","313","21","578",
                                         "0932","4321","8754","321","3223","4321","4212",
                                         "23","78","14","23","12","21","4","78","09","12",
                                         "5", "6", "7", "8", "9", "10", "2","3","24"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    } 
}
