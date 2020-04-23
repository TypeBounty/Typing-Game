using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuScreenController : MonoBehaviour
{
    //start game
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    //exit to main menu
    public void OnMouseDown()
    {
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

}
