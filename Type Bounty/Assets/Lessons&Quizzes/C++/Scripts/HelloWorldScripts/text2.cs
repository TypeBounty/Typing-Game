using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class text2 : MonoBehaviour
{
    List<string> secondchoice = new List<string>() { "Stores string value", "using namespace std","Store character value", "indicates the ending of function" };
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = secondchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (textcontrol.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = secondchoice[textcontrol.randQuestion];
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
