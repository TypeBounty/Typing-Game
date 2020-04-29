using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumWordGenerator : MonoBehaviour
{
    private static string[] wordList = { "1","32","22","985","700","313","21","54.3","578","3234.21","0932","4321","8754","321","3223","4321","4212","23","78","14","23","12","21","3","78","09","12","2","3","24"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    } 
}
