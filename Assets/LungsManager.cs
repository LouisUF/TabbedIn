using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LungsManager : MonoBehaviour
{
    public int breathInAmount;
    public int breatheInTime;
    public int breathOutAmount;
    public float currentTime;
    public bool inhale = false;
    public bool exhale = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int BreatheIn(bool exhale)
    {
        currentTime = 0;
        if (exhale)
        {
            while (!Input.GetKey(KeyCode.UpArrow))
            {
                currentTime += Time.deltaTime;
            }
            if (currentTime < 1)
            {
                breathInAmount = 1;
            }
            if (currentTime >= 1)
            {
                breathInAmount = 3 * (int)currentTime;
            }
        }
        return breathInAmount;
    }

    public int GetBreatheInTime(bool exhale)
    {
        int breatheInTime = 0;
        currentTime = 0;
        while (!Input.GetKey(KeyCode.UpArrow))
        {
            if (currentTime < 1)
            {
                breatheInTime = 1;
            }
            if (currentTime >= 1)
            {
                breatheInTime = (int)currentTime;
            }
        }
        return breatheInTime;
    }

    public int BreatheOut(bool inhale, int breatheInTime)
    {
        currentTime = 0;
        if (inhale)
        {
            while (!Input.GetKey(KeyCode.DownArrow))
            {
                currentTime += Time.deltaTime;
            }
            if (currentTime < breatheInTime)
            {
                breathOutAmount = 1;
            }
            if (currentTime >= breatheInTime)
            {
                breathOutAmount = 3 * (int)currentTime;
            }
            if (currentTime >= (breatheInTime * 2) && currentTime <= (breatheInTime * 2 + 5))
            {
                breathOutAmount = 6 * (int)currentTime;
            }
        }
        return breathOutAmount;
    }
}
