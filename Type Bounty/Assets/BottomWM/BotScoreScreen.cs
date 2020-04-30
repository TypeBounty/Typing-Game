using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BotScoreScreen : MonoBehaviour
{
    public static int scoreVal2;
    public Text score;
    public int scores;


    // Start is called before the first frame update
    void Start()
    {
        scoreVal2 = BotScore.scoreVal;
        score = GetComponent<Text>();

    }



    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreVal2;
        if (scoreVal2 == 2)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }
}
