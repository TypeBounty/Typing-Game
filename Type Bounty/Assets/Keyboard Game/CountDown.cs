using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public float targetTime;
    public Text time;

    private void Start()
    {
        targetTime = 60.0f;
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
            SceneManager.LoadScene("WordMangerScoreScreen");
        }
    }
}
