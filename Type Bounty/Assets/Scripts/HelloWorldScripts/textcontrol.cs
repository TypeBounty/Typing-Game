using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class textcontrol : MonoBehaviour
{
    /*initilizes a collection*/
    /*Changing number of questions,correct answers and previous question list<string>*/


    List<string> questions = new List<string>() { "What is the purpose of main?", "Why is the semicolon used?", "What is the use of ({)?", "Why is the (}) needed?" };
    List<string> correctAnswer = new List<string>() { "4", "4", "3", "2" };

    List<int> previousQuestions = new List<int>() { -1, -1, -1, -1, -1};
    public int questionNumber = 0;

    public Transform resultObj;
    public static string selectedAnswer;
    public static string choiceSelected = "n";
    //added 11/19
    public static string trigger = "n";

    public static int randQuestion=-1;
    public int catMod = 0;//not needed
    //gonna get rid of auraobj 1/29
    //public Transform auraObj;
    public float totalCorrect = 0;
    public static float totalQuestions = 0; //float into int
    public Transform scoreObj;
    public static float scorePer;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //scoreObj.GetComponent<TextMesh>().text = "Score: " + totalCorrect;
        if (totalQuestions > 0)
        {
            scorePer = (totalCorrect / totalQuestions) * 100;
        }
        scoreObj.GetComponent<TextMesh>().text = "Score: " + scorePer+ "%";
        //changred from 5+ to 4
        //randQuestion = Random.Range(0 + catMod, 5 + catMod);
        if (randQuestion == -1)
        {
            randQuestion = Random.Range(0, 4);
//<<<<<<< HEAD:Type Bounty/Assets/C++/textcontrol.cs
            resultObj.GetComponent<TextMesh>().text = " "; 
//=======
            //resultObj.GetComponent<TextMesh>().text = " ";
//>>>>>>> 66335ad010b82fccce862a2b7542a7cea4fd6c0a:Type Bounty/Assets/C++/SCriptsforC++/textcontrol.cs

            for (int i = 0; i < 4; i++)
            {
                if (randQuestion != previousQuestions[i])
                {
                    //do nothing
                }
                else
                {
                    randQuestion = -1;
                }
            }
        }

        if (randQuestion > -1)
        {
            GetComponent<TextMesh>().text = questions[randQuestion];
            previousQuestions[questionNumber] = randQuestion;
            
        }

        if (choiceSelected == "y") 
        {
            choiceSelected = "n";
            totalQuestions += 1;
            questionNumber += 1;

            if(correctAnswer [randQuestion]== selectedAnswer)
            {
                resultObj.GetComponent<TextMesh>().text = "Correct!! Click Next to Continue"  ;
                totalCorrect += 1;

            }
            
            else
            {
                nextbutton.resetAura = "n";
                resultObj.GetComponent<TextMesh>().text = "Incorrect Click Next to Continue";
            }
        }
    }
}
