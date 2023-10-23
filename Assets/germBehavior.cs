using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class germBehavior : MonoBehaviour
{
    public GameObject wound;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        this.transform.position += transform.right * speed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                Debug.Log("CLICKED " + hit.collider.name);
                if (GameObject.ReferenceEquals(hit.collider.gameObject, this.gameObject))
                    {
                    FindObjectOfType<AudioManager>().Play("correct3");
                    Destroy(this.gameObject);
                    }
                
            }
        }
    }
}
