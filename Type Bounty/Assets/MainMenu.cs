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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    public void Loops()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
    }

    public void WordCanvas()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 18);
    }
    public void TypingGameInstructions()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 17);
    }
    public void Game1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 19);
    }
    public void LeftRightGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 20);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}