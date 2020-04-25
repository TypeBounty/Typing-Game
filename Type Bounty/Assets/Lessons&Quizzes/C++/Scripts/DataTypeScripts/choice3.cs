using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choice3 : MonoBehaviour
{
    List<string> thirdchoice = new List<string>() {"Represents ONLY FALSE", "An int holds numeric value that has decimal point & int holds whole numbers", "Yes, for string and float are considered the same","TRUE" };


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = thirdchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (quizquest.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = thirdchoice[quizquest.randQuestion];
        }

        if (quizquest.trigger == "n")
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    void OnMouseDown()
    {
        quizquest.selectedAnswer = gameObject.name;
        quizquest.choiceSelected = "y";
        quizquest.trigger = "y";
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
