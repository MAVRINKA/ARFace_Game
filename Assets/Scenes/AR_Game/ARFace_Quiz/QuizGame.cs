using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.XR.ARFoundation;

public class QuizGame : MonoBehaviour
{
    public QuestionList[] questions;
    public TextMeshProUGUI[] answersText;
    private ARFaceManager arFaceManager;

    public TextMeshProUGUI qText;
    public GameObject headPanel;
    public GameObject endGamePanel;
    public Button[] answerBttns = new Button[4];
    //public Sprite[] TFIcons = new Sprite[2];
    //public Image TFIcon;
    public TextMeshProUGUI TFText;

    private int score = 0;
    private int numberQuestion;

    public TextMeshProUGUI infoTxt;
    public TextMeshProUGUI scoreTxt;


    List<object> qList;
    QuestionList crntQ;

    int randQ;
    bool defaultColor = false, trueColor = false, falseColor = false;

    private void Start()
    {
        arFaceManager = GameObject.Find("AR Session Origin").gameObject.GetComponent<ARFaceManager>();
        arFaceManager.facePrefab = null;

        numberQuestion = questions.Length;
    }

    void Update()
    {
        if (defaultColor) headPanel.GetComponent<Image>().color = Color.Lerp(headPanel.GetComponent<Image>().color, new Color(231 / 255.0F, 78 / 255.0F, 62 / 255.0F), 8 * Time.deltaTime);
        if (trueColor) headPanel.GetComponent<Image>().color = Color.Lerp(headPanel.GetComponent<Image>().color, new Color(104 / 255.0F, 184 / 255.0F, 89 / 255.0F), 8 * Time.deltaTime);
        if (falseColor) headPanel.GetComponent<Image>().color = Color.Lerp(headPanel.GetComponent<Image>().color, new Color(192 / 255.0F, 57 / 255.0F, 43 / 255.0F), 8 * Time.deltaTime);

        IdentityTxtScore();
    }

    public void OnClickPlay()
    {
        qList = new List<object>(questions);
        StartCoroutine(QuestionGenerate());
        //if (!headPanel.GetComponent<Animator>().enabled) headPanel.GetComponent<Animator>().enabled = true;
        //else headPanel.GetComponent<Animator>().SetTrigger("In");
    }
    IEnumerator QuestionGenerate()
    {
        if (qList.Count > 0)
        {
            randQ = Random.Range(0, qList.Count);
            crntQ = qList[randQ] as QuestionList;
            qText.text = crntQ.question;

            List<string> answers = new List<string>(crntQ.answers);

            for (int i = 0; i < crntQ.answers.Length; i++)
            {
                int rand = Random.Range(0, answers.Count);
                answersText[i].text = answers[rand];
                answers.RemoveAt(rand);
            }

            arFaceManager.enabled = false;
            yield return new WaitForSeconds(1);
            arFaceManager.enabled = true;
            GameObject faceID = crntQ.faceARVariable;
            arFaceManager.facePrefab = faceID;

            TFText.enabled = false;
            //qText.gameObject.GetComponent<Animator>().SetTrigger("In");
            
            //StartCoroutine(animBttns());
        }
        else
        {
            print("�� ������ ����");
            StartCoroutine(CompleteGame());
        }
    }

    IEnumerator CompleteGame()
    {
        if(score <= numberQuestion / 2)
            infoTxt.text = "����� ������� ���������������!";
        else
            infoTxt.text = infoTxt.text;

        yield return new WaitForEndOfFrame();
        endGamePanel.SetActive(true);
    }

    IEnumerator TrueOrFalse(bool check)
    {
        defaultColor = false;
        for (int i = 0; i < answerBttns.Length; i++) answerBttns[i].interactable = false;
        yield return new WaitForSeconds(1);
        //for (int i = 0; i < answerBttns.Length; i++) answerBttns[i].gameObject.GetComponent<Animator>().SetTrigger("Out");
        //qText.gameObject.GetComponent<Animator>().SetTrigger("Out");
        //if (!TFIcon.gameObject.activeSelf) TFIcon.gameObject.SetActive(true);
        //else TFIcon.gameObject.GetComponent<Animator>().SetTrigger("In");
        if (check)
        {
            trueColor = true;
            //TFIcon.sprite = TFIcons[0];
            TFText.enabled = true;
            TFText.text = "���������� �����";
            score += 1;
            yield return new WaitForSeconds(2);
            //TFIcon.gameObject.GetComponent<Animator>().SetTrigger("Out");
            qList.RemoveAt(randQ);
            StartCoroutine(QuestionGenerate());
            for (int i = 0; i < answerBttns.Length; i++) answerBttns[i].interactable = true;
            trueColor = false;
            defaultColor = true;
            yield break;
        }
        else
        {
            falseColor = true;
            //TFIcon.sprite = TFIcons[1];
            TFText.text = "������������ �����";
            TFText.enabled = true;
            yield return new WaitForSeconds(2);
            qList.RemoveAt(randQ);
            StartCoroutine(QuestionGenerate());
            for (int i = 0; i < answerBttns.Length; i++) answerBttns[i].interactable = true;
            //TFIcon.gameObject.GetComponent<Animator>().SetTrigger("Out");
            //headPanel.GetComponent<Animator>().SetTrigger("Out");
            falseColor = false;
            defaultColor = true;
            yield break;
        }
    }
    public void AnswerBtns(int index)
    {
        if (answersText[index].text.ToString() == crntQ.answers[0]) StartCoroutine(TrueOrFalse(true));
        else StartCoroutine(TrueOrFalse(false));
    }

    public void IdentityTxtScore()
    {
        scoreTxt.text = score.ToString() + "/" + numberQuestion;
    }
}
[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] answers = new string[4];
    public GameObject faceARVariable;
}
