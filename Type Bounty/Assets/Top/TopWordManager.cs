using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopWordManager : MonoBehaviour
{
    public List<TopWord> words;

    public TopWordSpawner wordSpawner;

    private bool hasActiveWord;
    private TopWord activeWord;

    private void Start()
    {
        AddWord();
    }

    public void AddWord()
    {
        TopWord word = new TopWord(TopWordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
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
            foreach (TopWord word in words)
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
