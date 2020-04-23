using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class nextbutton : MonoBehaviour
{
    public static string resetAura = "n";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        //create temp ref to the current scene
        Scene currentScene = SceneManager.GetActiveScene();

        //retrieve name of scene
        string sceneName = currentScene.name;

        if (sceneName == "HelloWorldQUIZ")
        {
            //11-12
            //transition to score
            //11/19 update if statement to prevent it from transfering 
            if (textcontrol.totalQuestions != 4 && textcontrol.trigger == "y")
            {
                textcontrol.randQuestion = -1;
                resetAura = "y";
                textcontrol.trigger = "n";
            }
            if (textcontrol.totalQuestions == 4 && textcontrol.trigger == "y")
            {
                //SceneManager.LoadScene("ScoreScreenHW");
                SceneManager.LoadScene("ScoreScreenHW");
            }
        }
        else if (sceneName == "DataTypesQUIZ") {
            //added 2-1
            if (quizquest.totalQuestions != 4 && quizquest.trigger == "y")
            {
                quizquest.randQuestion = -1;
                resetAura = "y";
                quizquest.trigger = "n";
            }
            if (quizquest.totalQuestions == 4 && quizquest.trigger == "y")
            {
                //SceneManager.LoadScene("ScoreScreenDT");
                SceneManager.LoadScene("ScoreScreenDT");
            }
        }
        else if (sceneName == "LoopsQUIZ")
        {
            if (qq.totalQuestions != 4 && qq.trigger == "y")
            {
                qq.randQuestion = -1;
                resetAura = "y";
                qq.trigger = "n";
            }
            if (qq.totalQuestions == 4 && qq.trigger == "y")
            {
                SceneManager.LoadScene("ScoreScreenLP");
            }
        }
    }
}
 