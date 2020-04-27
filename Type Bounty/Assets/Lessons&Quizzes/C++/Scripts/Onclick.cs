using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onclick : MonoBehaviour
{
    public void OnMouseDown()
    {
        //create temp ref to the current scene
        Scene currentScene = SceneManager.GetActiveScene();

        //retrieve name of scene
        string sceneN = currentScene.name;

        if (sceneN == "ScoreScreenHW")
        {

            if (textcontrol.scorePer > 69.9)
            {
                //would like to go to the main menu
            }
            else
            {
                //will need to be updated for later 1/29
                SceneManager.LoadScene("HelloWorld1");
            }
        }

        else if (sceneN == "ScoreScreenDT")
        {

            //might need to add some small bells and whistles for it to work properly
            if (quizquest.scorePer > 69.9)
            {
                //would like to go to the main menu
            }
            else
            {
                //will need to be updated for later 1/29
                SceneManager.LoadScene("DataTypes1");
            }
        }

        else if (sceneN == "ScoreScreenLP")
        {

            //might need to add some small bells and whistles for it to work properly
            if (qq.scorePer > 69.9)
            {
                //would like to go to the main menu
            }
            else
            {
                //will need to be updated for later 1/29
                SceneManager.LoadScene("Loops1");
            }
        }

    }
}
