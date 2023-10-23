using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthHitbox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject healthManager;

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "BadFood")
        {
            Debug.Log("Contact");
            Destroy(col.gameObject);
            healthManager.GetComponent<HealthManager>().TakeDamage(10);
        }
        if (col.gameObject.tag == "GoodFood")
        {
            Debug.Log("Contact");
            Destroy(col.gameObject);
            healthManager.GetComponent<HealthManager>().Heal(2);
        }
    }
}
