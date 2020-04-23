using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class text4 : MonoBehaviour
{
    List<string> fourthchoice = new List<string>() { "Its purpose is to run when the program is called.", "Equivalent to ending a sentense with a period", "Stores string value", "indicates the ending of function" };
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = fourthchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (textcontrol.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = fourthchoice[textcontrol.randQuestion];
        }
        //added 11/19
        if (textcontrol.trigger == "n")
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
        textcontrol.selectedAnswer = gameObject.name;
        textcontrol.choiceSelected = "y";
        //added 11/19
        textcontrol.trigger = "y";
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
