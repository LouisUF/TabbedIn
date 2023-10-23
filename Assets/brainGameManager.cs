using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class brainGameManager : MonoBehaviour
{
    public GameObject tab;
    public GameObject tabManager;
    public int flatTime;
    public List<string> problems;
    public List<string> answers;
    public List<string> hardProblems;
    public List<string> hardAnswers;

    private int counter;
    public GameObject brainTimer;

    public TextMeshPro targetWord;
    public AudioManager audio;
    string typedWord;
    TMP_InputField iField;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        iField = gameObject.GetComponent<TMP_InputField>();
        targetWord.text = problems[counter];
    }

    void MyFunction()
    {
        Debug.Log(iField.text);
        typedWord = iField.text;

        if (typedWord == answers[counter])
        {
            audio.Play("correct2");
            counter = Random.Range(0, problems.Count);
            iField.text = "";
            iField.ActivateInputField();
            targetWord.text = problems[counter];
            brainTimer.GetComponent<BrainTimer>().addTime(25);

        }
        else
        {
            audio.Play("invalid");
            iField.text = "";
            iField.ActivateInputField();
        }
    }
    // Update is called once per frame
    void Update()
    {
        bool isTop;
        if (tab.name == tabManager.GetComponent<clickManager>().topTab)
        {
            isTop = true;
        }
        else
        {
            isTop = false;
        }
        if (isTop && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("FunctionCall");
            MyFunction();
        }


    }

    /*
    private IEnumerator StartHeartRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(flatTime + Random.Range(1, 5));

            //int word = Random.Range(0, wordsEasy.Count);
            //targetWord.text = wordsEasy[word];
        }
    }
    */

    private void SubmitName(string arg0)
    {
        Debug.Log(arg0);
    }
}
