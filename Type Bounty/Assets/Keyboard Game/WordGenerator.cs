using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList = { "int", "float", "string", "boolean", "bool", "#include<iostream>", "main()", "for()", "while()",
                                         "do{}while()",";", "if()", "if(){}else{}", "double", "#include<string>", "cout <<", "cin >>",
                                         "int x;", "//comment", "/*comments*/", "return(0);", "char"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}