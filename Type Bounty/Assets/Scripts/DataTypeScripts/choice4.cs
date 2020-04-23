using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choice4 : MonoBehaviour
{
    List<string> fourthchoice = new List<string>() {"Represents TRUE AND FALSE", "An int holds a character & a float will hold either TRUE or FALSE", "No, for strings and float values are not considered the same","'Hello World'" };
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = fourthchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (quizquest.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = fourthchoice[quizquest.randQuestion];
        }
        //added 11/19
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
