using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void HelloWorld()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void DataTypes()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }


    public void Loops()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

    public void WordCanvas()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
    }

    public void TypingGameInstructions()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
    }
   
   
    public void Game1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 14);
    }
    public void LeftRightGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15);
    }
    public void TopRowWM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 16);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}