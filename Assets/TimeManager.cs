using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float currentTime;
    public TMP_Text displayAge;
    public int currentAge = 0;
    // Start is called before the first frame update
    void Start()
    {
        displayAge.text = "Age: 0";
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (Mathf.Round(currentTime) % 5 == 0)
        {
            currentTime += 1;
            currentAge++;
            displayAge.text = "Age: " + currentAge.ToString();
        }
    }
}
