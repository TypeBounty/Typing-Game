using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotScore : MonoBehaviour
{
    public static int scoreVal;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        scoreVal = 0;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreVal;
        if (scoreVal == 2)
        {
            //SceneManager.LoadScene("BotScoreScreen");
        }
    }
}
