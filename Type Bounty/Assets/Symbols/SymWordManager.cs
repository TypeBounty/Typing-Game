using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymWordManager : MonoBehaviour
{
    public List<SymWord> words;

    public SymWordSpawner wordSpawner;

    private bool hasActiveWord;
    private SymWord activeWord;

    private void Start()
    {
        AddWord();
    }

    public void AddWord()
    {
        SymWord word = new SymWord(SymWordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
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
            foreach (SymWord word in words)
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
