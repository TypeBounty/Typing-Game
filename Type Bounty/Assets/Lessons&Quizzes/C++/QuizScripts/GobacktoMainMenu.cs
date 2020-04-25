using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GobacktoMainMenu : MonoBehaviour
{
    public void OnMouseDown()
    {
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
