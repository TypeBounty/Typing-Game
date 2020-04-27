using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class text1 : MonoBehaviour
{
    List<string> firstchoice = new List<string>() {"<<","#include<iostream>","stores integer","operator","<<"};

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<TextMesh>().text = firstchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (textcontrol.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = firstchoice[textcontrol.randQuestion];
        }
        //added 11/19
        if(textcontrol.trigger == "n")
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
