using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LungsTimer : MonoBehaviour
{
    public float decreaseSpeed;
    public float maxTime = 100f;
    public Image timeBar;
    public GameObject healthManager;

    public int breathInAmount;
    public int breatheInTime;
    public int breathOutAmount;
    public float currentTime;
    public bool inhale = false;
    public bool exhale = true;
    public int breathTotalAmount = 0;

    public GameObject lungsIn;
    public GameObject lungsOut;
    public bool didInhale = false;

    void Start()
    {

    }

    void Update()
    {
        maxTime = Mathf.Clamp(maxTime, 0, 100);
        maxTime -= Time.deltaTime * decreaseSpeed;
        timeBar.fillAmount = maxTime / 100f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            lungsIn.SetActive(true);
            lungsOut.SetActive(false);
            didInhale = true;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            lungsIn.SetActive(false);
            lungsOut.SetActive(true);
            if(didInhale){
                maxTime += 5;
                didInhale = false;
            }
        }
        if (maxTime <= 1)
        {
            healthManager.GetComponent<HealthManager>().TakeDamage(20);
            maxTime = 100f;
        }
    }
}
