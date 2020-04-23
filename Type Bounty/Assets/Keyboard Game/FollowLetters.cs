using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowLetters : MonoBehaviour
{
    Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        do
        {
            tempPos = transform.position;

            tempPos.x += 2.0f;
            tempPos.y -= 2.0f;

            transform.position = tempPos;

        } while (false);

      
    }

}
