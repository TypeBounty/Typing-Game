using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a2 : MonoBehaviour
{
    List<string> secondchoice = new List<string>() { "It runs when the for loop is ran","When the condition is neither true or false", "do-while loops at least once even if condition is false & while loop runs only when true","Needs a condition and declare a variable type"};
   // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = secondchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (qq.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = secondchoice[qq.randQuestion];
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
