﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreToGame : MonoBehaviour
{
    // Start is called before the first frame update
   public void JumpShip()
    {
        SceneManager.LoadScene("WordManager2");
    }

    
}