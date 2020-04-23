using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRWordManager : MonoBehaviour
{
    public List<LRWord> words;
    private bool hasActiveWord;
    private LRWord activeWord;

    public LRWordSpawner wordSpawner;

   /* private void Start()
    {
        AddWord();
        AddWord();
        AddWord();
    }
*/
    public void AddWord()
    {
        LRWord word = new LRWord(LRWordGenerator.GetWordList(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            //check if letter was next
            //remove it from the word
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        } else
        {
            foreach(LRWord word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if(hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }

    }
}
