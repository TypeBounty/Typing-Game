using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SymCountDown : MonoBehaviour
{
    public float targetTime;
    public Text time;

    private void Start()
    {
        targetTime = 2.0f;
        UpdateTimeRemainingDisplay();
    }


    private void UpdateTimeRemainingDisplay()
    {
        time.text = "Time: " + Mathf.Round(targetTime).ToString();
    }

    void Update()
    {
        UpdateTimeRemainingDisplay();
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            //timerEnded();
            SceneManager.LoadScene("SymScoreScreen");
        }
    }
}
