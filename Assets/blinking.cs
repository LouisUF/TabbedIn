using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinking : MonoBehaviour
{
    public GameObject theSprite;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartBlinking());
    }

    IEnumerator StartBlinking()
    {
        yield return new WaitForSeconds(1);
        theSprite.GetComponent<SpriteRenderer>().enabled = !theSprite.GetComponent<SpriteRenderer>().enabled;
        StartCoroutine(StartBlinking());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
