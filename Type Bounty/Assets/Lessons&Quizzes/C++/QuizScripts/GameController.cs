using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Text questionTest;
    public Text scoreDisplayText;
    public Text timeRemainingDisplayText;
    public SimpleObjectPool answerButtonObjectPool;
    public Transform answerButtonParent;
    public GameObject questionDisplay;
    public GameObject roundEndDisplay;

    private DataController dataController;
    private RoundData currentRoundData;
    private QuestionData[] questionPool;

    private bool isRoundActive;
    private float timeRemaining;
    private int questionIndex;
    private int playerScore;
    private List<GameObject> answerButtonGameObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {

        dataController = FindObjectOfType<DataController>();
        currentRoundData = dataController.GetCurrentRoundData();
        questionPool = currentRoundData.questions;
        timeRemaining = currentRoundData.timeLimitInSeconds;
        UpdateTimeRemainingDisplay();

        playerScore = 0;
        questionIndex = 0;

        ShowQuestion();
        isRoundActive = true;
    }

    private void ShowQuestion()
    {
        RemoveAnswerButton();
        //questionPool position index store it into question data
        QuestionData questionData = questionPool[questionIndex];
        //get question from that question & get string of actual question and display that with questionTest UI elem
        questionTest.text = questionData.questionText;

       // loop over all the answer and add buttons as needed
       for(int i=0; i < questionData.answers.Length; i++)
        {
            GameObject answerButtonGameObject = answerButtonObjectPool.GetObject();
            answerButtonGameObjects.Add(answerButtonGameObject);
            answerButtonGameObject.transform.SetParent(answerButtonParent);
            
            //get reference of AnswerButton & pass set it up in given pos i
            AnswerButton answerButton = answerButtonGameObject.GetComponent<AnswerButton>();
            answerButton.Setup(questionData.answers[i]);
        }
    }

    private void RemoveAnswerButton()
    {
        while(answerButtonGameObjects.Count >0)
        {
        answerButtonObjectPool.ReturnObject(answerButtonGameObjects[0]);
        answerButtonGameObjects.RemoveAt(0);
        }
    }

    public void AnswerButtonClicked(bool isCorrect)
    {
        if(isCorrect)
        {
            playerScore += currentRoundData.pointsAddedForCorrectAnswer;
            scoreDisplayText.text = "Score: " + playerScore.ToString();
        }
        if(questionPool.Length > questionIndex +1)
        {
            questionIndex++;
            ShowQuestion();
        }
        else
        {
            //end round
            EndRound();
        }
    }

    public void EndRound()
    {
        isRoundActive = false;

        questionDisplay.SetActive(false);
        roundEndDisplay.SetActive(true);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    private void UpdateTimeRemainingDisplay()
    {
        timeRemainingDisplayText.text = "Time: " + Mathf.Round(timeRemaining).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(isRoundActive)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimeRemainingDisplay();
        }

        if(timeRemaining <= 0f)
        {
            EndRound();
        }
    }
}
