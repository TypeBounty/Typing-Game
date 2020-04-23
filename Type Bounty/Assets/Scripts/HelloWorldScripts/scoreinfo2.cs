using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //11-17
public class scoreinfo2 : MonoBehaviour
{
    public Transform Score; //named the same as prev in textcontroll
    public Transform Textresult;
    //remmember ScorePer textcontrol is static
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.GetComponent<TextMesh>().text = textcontrol.scorePer + "%";
        if (textcontrol.scorePer > 69.9)
        {
            Textresult.GetComponent<TextMesh>().text = "You Passed! Move on to next lesson";
            Debug.Log("You Passed! Move on to next lesson");
            //make the button send you to new lesson
        }
        else
        {
            Textresult.GetComponent<TextMesh>().text = "You Failed!" + " Go back and review the lecture!";
            Debug.Log("You Failed! Go back!");
            //make button send you back to beginning of lesson
            //SceneManager.LoadScene("Learningc++1");
        }
    }
    /*
    //create temp ref to the current scene
    Scene currentScene = SceneManager.GetActiveScene();

    //retrieve name of scene
    string nameofscene = currentScene.name;

    if (nameofscene == "HelloWorldQUIZ")
    {

        Score.GetComponent<TextMesh>().text = textcontrol.scorePer + "%";
        if (textcontrol.scorePer > 69.9)
        {
            Textresult.GetComponent<TextMesh>().text = "You Passed! Move on to next lesson";
            Debug.Log("You Passed! Move on to next lesson");
            //make the button send you to new lesson
        }
        else
        {
            Textresult.GetComponent<TextMesh>().text = "You Failed!" + " Go back and review the lecture!";
            Debug.Log("You Failed! Go back!");
            //make button send you back to beginning of lesson
            //SceneManager.LoadScene("Learningc++1");
        }
    }

    else if (nameofscene == "DataTypesQUIZ")
    {

        //might need to check if i need an active screen to fix issue
        Score.GetComponent<TextMesh>().text = quizquest.scorePer + "%";
        if (quizquest.scorePer > 69.9)
        {
            Textresult.GetComponent<TextMesh>().text = "You Passed! Move on to next lesson";
            Debug.Log("You Passed! Move on to next lesson");
            //make the button send you to new lesson
        }
        else
        {
            Textresult.GetComponent<TextMesh>().text = "You Failed!" + " Go back and review the lecture!";
            Debug.Log("You Failed! Go back!");
            //make button send you back to beginning of lesson
            //SceneManager.LoadScene("Learningc++1");
        }
    }


}
*/
}
