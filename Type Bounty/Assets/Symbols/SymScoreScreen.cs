using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SymScoreScreen : MonoBehaviour
{
        scoreVal2 = SymScore.scoreVal;
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
