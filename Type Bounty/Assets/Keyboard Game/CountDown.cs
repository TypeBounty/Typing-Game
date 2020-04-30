using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CountDown : MonoBehaviour
{

    /*
        public Text timeRemainingDisplayText;
        private DataController dataController;
        private RoundData currentRoundData;
        private float timeRemaining;



        // Start is called before the first frame update
        void Start()
        { 
            currentRoundData = dataController.GetCurrentRoundData();
            timeRemaining = currentRoundData.timeLimitInSeconds + 30f;
            UpdateTimeRemainingDisplay();
        }


        private void UpdateTimeRemainingDisplay()
        {
            timeRemainingDisplayText.text = "Time: " + Mathf.Round(timeRemaining).ToString();
        }


        // Update is called once per frame
        void Update()
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimeRemainingDisplay();
        }*/

    public float targetTime;
    public Text time;

    private void Start()
    {
        targetTime = 10.0f;
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
