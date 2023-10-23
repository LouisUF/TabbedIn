using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrainTimer : MonoBehaviour
{
    public float decreaseSpeed;
    public float maxTime = 100f;
    public Image timeBar;
    public GameObject healthManager;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        maxTime = Mathf.Clamp(maxTime, 0, 100);
        maxTime -= Time.deltaTime * decreaseSpeed;
        timeBar.fillAmount = maxTime / 100f;

        if (maxTime <= 1)
        {
            healthManager.GetComponent<HealthManager>().TakeDamage(15);
            maxTime = 100f;
        }
    }

    public void addTime(float timeAmount)
    {
        maxTime += timeAmount;
        maxTime = Mathf.Clamp(maxTime, 0, 100);
    }
}

