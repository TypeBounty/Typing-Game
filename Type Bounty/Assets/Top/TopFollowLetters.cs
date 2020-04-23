using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopFollowLetters : MonoBehaviour
{
    public TopWordDisplay removeWord;
    public TopWordDisplay wordDisplay;

    Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TopWordDisplay.moveShip == true)
        {
            tempPos = transform.position;
            tempPos.x = TopWordDisplay.wordPosx;
            tempPos.y = TopWordDisplay.wordPosy;// - 800;
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
