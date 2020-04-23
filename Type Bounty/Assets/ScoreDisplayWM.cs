using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayWM : MonoBehaviour
{
    public int HighScore = Score.scoreVal;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        //HighScore = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        score = GetComponent<Text>();
        score.text = "Score: " + HighScore;
        HighScore = 0;
       

}
}
