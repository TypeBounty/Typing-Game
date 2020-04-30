using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayWM : MonoBehaviour
{
    public static int scoreVal2;
    public Text score;
   


    // Start is called before the first frame update
    void Start()
    {
        scoreVal2 = Score.scoreVal;
        score = GetComponent<Text>();

    }

     

// Update is called once per frame
void Update()
    {
        score.text = "Score: " + scoreVal2;
        if (scoreVal2 == 10)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }
}
