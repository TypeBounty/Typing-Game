using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowLetters : MonoBehaviour
{
    public WordDisplay removeWord;
    public WordDisplay wordDisplay;

    Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (WordDisplay.moveShip == true)
        {
            tempPos = transform.position;
            tempPos.x = WordDisplay.wordPosx;
            tempPos.y = WordDisplay.wordPosy;// - 800;
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
