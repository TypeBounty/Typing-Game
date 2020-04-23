using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choice2 : MonoBehaviour
{
    List<string> secondchoice = new List<string>() {"Represents ONLY TRUE", "An int holds a whole number & float holds a numeric value with decimal points", "Yes, as they both share the same number","764.3" };
   // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = secondchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (quizquest.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = secondchoice[quizquest.randQuestion];
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
