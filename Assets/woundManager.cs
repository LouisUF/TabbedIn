using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject germ;
    public GameObject healthManager;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Germ")
        {
            Debug.Log("Contact");
            Destroy(col.gameObject);
            healthManager.GetComponent<HealthManager>().TakeDamage(5);
        }
    }
}
