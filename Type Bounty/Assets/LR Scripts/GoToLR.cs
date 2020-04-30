using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToLR : MonoBehaviour
{
    public void JumpToLR()
    {
        SceneManager.LoadScene("LeftRightGame");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
