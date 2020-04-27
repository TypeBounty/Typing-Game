using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a4 : MonoBehaviour
{
    List<string> fourthchoice = new List<string>() {"It runs when the condition is neither true or false","When the condition is true","Do-while only loop once in the whole operation & the while loops more than once","Declare a variable type, a condition, and incrementing a variable"};
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = fourthchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (qq.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = fourthchoice[qq.randQuestion];
        }
        //added 11/19
        if (qq.trigger == "n")
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
        qq.selectedAnswer = gameObject.name;
        qq.choiceSelected = "y";
        qq.trigger = "y";
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
