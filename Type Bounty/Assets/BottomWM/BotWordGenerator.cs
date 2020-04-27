using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotWordGenerator : MonoBehaviour
{
    private static string[] wordList = { "z","x","c","v","b","n","m","vzxc","xcvn","xmzxzvx","zxvbmzxcbm","czmnxbvc","cxvnz","mmzxnbcvb","cnn"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    } 
}
