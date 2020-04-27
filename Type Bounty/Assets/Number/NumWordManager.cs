using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumWordManager : MonoBehaviour
{
    public List<NumWord> words;

    public NumWordSpawner wordSpawner;

    private bool hasActiveWord;
    private NumWord activeWord;

    private void Start()
    {
        AddWord();
    }

    public void AddWord()
    {
        NumWord word = new NumWord(NumWordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            //Check if letter was next
            //Remove it from the word
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }

        }
        else
        {
            foreach (NumWord word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            AddWord();
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }

    /*public static void getOut()
    {
        words.Remove(activeWord);
    }*/

}
