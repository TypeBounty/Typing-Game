﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TopWord
{
    public string word;
    private int typeIndex;

    private TopWordDisplay display;
    public TopWordManager wordManager;

    public TopWord(string _word, TopWordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }


    public void TypeLetter()
    {
        typeIndex++;
        //Remove letter on screen
        display.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            //Update Score
            TopScore.scoreVal++;

            //Update Position of Ship

            //Remove the word from the screen
            display.removeWord();
            
        }
        return wordTyped;
    }
}
