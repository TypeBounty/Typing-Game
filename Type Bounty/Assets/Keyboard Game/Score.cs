﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int scoreVal;
    public Text score;
    public int scores;


    // Start is called before the first frame update
    void Start()
    {
        scores = scoreVal;
        score.text = "Score: " + scores;
        scoreVal = 0;
        score = GetComponent<Text>();

        
    }



    // Update is called once per frame
    void Update()
    {
        scores = scoreVal;
        score.text = "Score: " + scoreVal;
        if(scoreVal == 10)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }
}
