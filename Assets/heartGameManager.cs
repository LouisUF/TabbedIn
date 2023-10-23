using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class heartGameManager : MonoBehaviour
{
    public GameObject tab;
    public GameObject tabManager;
    public int flatTime;
    public List<string> words;
    public List<string> hardWords;
    private int counter;
    public GameObject heartTimer;

    public TextMeshPro targetWord;
    string typedWord;
    TMP_InputField iField;

    public bool hardMode = false;
    public AudioManager audio;

    public GameObject smallHeart;
    public GameObject bigHeart;


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        iField = gameObject.GetComponent<TMP_InputField>();
        targetWord.text = words[counter];
    }

    void MyFunction()
    {
        Debug.Log(iField.text);
        typedWord = iField.text;

        if (typedWord == targetWord.text)
        {
            heartTimer.GetComponent<HeartTimer>().addTime(25);
            audio.Play("correct1");
            StartCoroutine("HeartBeat");
            if (hardMode)
            {
                counter = Random.Range(0, hardWords.Count);
                iField.text = "";
                iField.ActivateInputField();
                targetWord.text = hardWords[counter];
            }
            else
            {
                counter = Random.Range(0, words.Count);
                iField.text = "";
                iField.ActivateInputField();
                targetWord.text = words[counter];
            }
        }
        else
        {
            audio.Play("invalid");
            iField.text = "";
            iField.Select();
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

    private IEnumerator HeartBeat()
    {
        bigHeart.SetActive(true);
        yield return new WaitForSeconds(0.60f);
        bigHeart.SetActive(false);
    }
}
