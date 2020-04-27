using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotScore : MonoBehaviour
{
    public static int scoreVal = 0;
    Text score;

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
        if (scoreVal == 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }
}
