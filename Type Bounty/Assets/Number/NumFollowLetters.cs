using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumFollowLetters : MonoBehaviour
{
    public NumWordDisplay removeWord;
    public NumWordDisplay wordDisplay;

    Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (NumWordDisplay.moveShip == true)
        {
            tempPos = transform.position;
            tempPos.x = NumWordDisplay.wordPosx;
            tempPos.y = NumWordDisplay.wordPosy;// - 800;
            transform.position = tempPos;
        }
        /* do
         {
             tempPos = transform.position;

             tempPos.x += 2.0f;
             tempPos.y -= 2.0f;

             transform.position = tempPos;

         } while (false);
         */
    }

    }
