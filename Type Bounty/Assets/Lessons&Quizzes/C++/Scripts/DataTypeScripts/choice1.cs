using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choice1 : MonoBehaviour
{
    List<string> firstchoice = new List<string>() {"Represents TRUE OR FALSE","There is no difference between both kinds of data types", "No, because the string 10 is missing a .0 at the end","0" };
    // Start is called before the first frame update
    void Start()
    {
 

    }

    // Update is called once per frame
    void Update()
    {
        if (quizquest.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = firstchoice[quizquest.randQuestion];
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
