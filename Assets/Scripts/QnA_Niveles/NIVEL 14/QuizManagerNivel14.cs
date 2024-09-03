using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using Unity.VisualScripting;

public class QuizManagerNivel14 : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject QuizScene;
    //public GameObject FailedScene;
    //public GameObject CompleteScene;

    public Text QuestionTxt;
    //public Text ScoreTxt_Fail;
    //public Text ScoreTxt_Success;

    int totalQuestions = 0;
    public int score;

    private void Start()
    {
        totalQuestions = QnA.Count;
        //FailedScene.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        QuizScene.SetActive(false);
        if (score == 1)
        {
            SceneManager.LoadScene(97);
            //CompleteScene.SetActive(true);
            //ScoreTxt_Success.text = score + "/" + totalQuestions;
        }
        else
        {
            SceneManager.LoadScene(98);
            //FailedScene.SetActive(true);
            //ScoreTxt_Fail.text = score + "/" + totalQuestions;
        }
    }

    public void correct()
    {
        // when you answer right
        score += 1;
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(WaitForNext());
        // generateQuestion();
    }

    public void wrong()
    {
        // when you answer wrong
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(WaitForNext());
        // generateQuestion();
    }

    IEnumerator WaitForNext()
    {
        yield return new WaitForSeconds(1);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScriptLevel14>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScriptLevel14>().isCorrect = true;
            }
            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswerScriptLevel14>().startColor;
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            // genera las preguntas de forma aleatoria
            //currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }
    }

}
