using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidWordManager : MonoBehaviour
{
    public List<MidWord> words;

    public MidWordSpawner wordSpawner;

    private bool hasActiveWord;
    private MidWord activeWord;

    private void Start()
    {
        AddWord();
    }

    public void AddWord()
    {
        MidWord word = new MidWord(MidWordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
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
            foreach (MidWord word in words)
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
