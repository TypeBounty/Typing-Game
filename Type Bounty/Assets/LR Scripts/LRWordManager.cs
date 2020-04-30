using System;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class LRWordManager : MonoBehaviour
{
    public List<LRWord> words;
    private bool hasActiveWord;
    private LRWord activeWord;
    //public LRWord word;

    private enum AudioClipType
    {
    GoodWord = 0,
    GoodLetter = 1,
    BadLetter = 2
    }

    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip[] _audioClips;

    public LRWordSpawner wordSpawner;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        //AddWord();
        //AddWord();
        //AddWord();
    }

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
            if (activeWord.GetNextLetter() == letter)
            {
                PlayFeedbackSound(AudioClipType.GoodLetter);
                activeWord.TypeLetter();
            }
            else
            {
                PlayFeedbackSound(AudioClipType.BadLetter);
            }
        }
        else
        {
            //foreach(char c in Input.inputString)
            foreach (LRWord word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    //_inputChar = c;
                    activeWord = word;
                    hasActiveWord = true;
                    PlayFeedbackSound(AudioClipType.GoodLetter);
                    word.TypeLetter();
                    PlayFeedbackSound(AudioClipType.GoodWord);
                    break;
                }
                else if (word.GetNextLetter() != letter/*&& hasActiveWord==false*/)
                {
                    PlayFeedbackSound(AudioClipType.BadLetter);
                }
            }
            if(hasActiveWord == false)
            {
                PlayFeedbackSound(AudioClipType.BadLetter);
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            PlayFeedbackSound(AudioClipType.GoodWord);
            words.Remove(activeWord);
            SceneManager.LoadScene("LR_Game_Passed");
        }

    }

    private void PlayFeedbackSound(AudioClipType type)
    {
    _audioSource.clip = _audioClips[(int)type];
    _audioSource.Play();
    }
}
