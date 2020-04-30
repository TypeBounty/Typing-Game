using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreToGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void JumpShip()
    {
        SceneManager.LoadScene("WordManager2");

        /*switch scene
        case 1: SceneManager.LoadScene("WordManager2");
        case 2: SceneManager.LoadScene("TopWM");*/

        }

    public void Returntowmtop()
    {
        SceneManager.LoadScene("TopWM");

    }
    public void Returntowmmid()
    {
        SceneManager.LoadScene("MidWM");

    }
    public void Returntowmbot()
    {
        SceneManager.LoadScene("BOTwm");

    }
    public void Returntownum()
    {
        SceneManager.LoadScene("NumberWM");

    }
    public void Returntowmsym()
    {
        SceneManager.LoadScene("SymWM");

    }
}
