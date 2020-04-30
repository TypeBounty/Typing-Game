using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int scoreVal;
    public Text score;
    


    // Start is called before the first frame update
    void Start()
    {
        scoreVal = 0;
        score = GetComponent<Text>();
       // ScoreDisplayWM.scene = 1;
    }



    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreVal;
        if(scoreVal == 10)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }
}
