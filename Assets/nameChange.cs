using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class nameChange : MonoBehaviour
{

    public GameObject bri;
    public GameObject amanda;
    public GameObject alex;
    public GameObject louis;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        bri.SetActive(true);
        amanda.SetActive(false);
        alex.SetActive(false);
        louis.SetActive(false);
        StartCoroutine(StartChanging());
    }

    IEnumerator StartChanging()
    {
        yield return new WaitForSeconds(2);
        bri.SetActive(false);
        amanda.SetActive(true);
        yield return new WaitForSeconds(2);
        amanda.SetActive(false);
        alex.SetActive(true);
        yield return new WaitForSeconds(2);
        alex.SetActive(false);
        louis.SetActive(true);
        yield return new WaitForSeconds(2);
        louis.SetActive(false);
        bri.SetActive(true);

        StartCoroutine(StartChanging());
    }

    // Update is called once per frame
    void Update()
    {
    }
}
