using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    public float speed = 0.34f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z); 
       // this.transform.position += -transform.up * speed * Time.deltaTime;
        this.transform.Rotate(0, 90 * Time.deltaTime, 0);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                Debug.Log("CLICKED " + hit.collider.name);
                if (GameObject.ReferenceEquals(hit.collider.gameObject, this.gameObject))
                {
                    FindObjectOfType<AudioManager>().Play("correct4");
                    Destroy(this.gameObject);
                }

            }
        }
    }
}
