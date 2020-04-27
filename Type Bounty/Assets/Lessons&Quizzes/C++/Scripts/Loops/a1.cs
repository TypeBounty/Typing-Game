using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a1 : MonoBehaviour
{
    List<string> firstchoice = new List<string>() {"It runs when the condition is true","When the condition is put inside a for loop","There are no differences","Only needs a condition to have a for loop"};
    // Start is called before the first frame update
    void Start()
    {
 

    }

    // Update is called once per frame
    void Update()
    {
        if (qq.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = firstchoice[qq.randQuestion];
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
