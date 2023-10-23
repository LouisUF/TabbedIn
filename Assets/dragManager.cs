using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragManager : MonoBehaviour
{
    // The plane the object is currently being dragged on
    private Plane dragPlane;

    // The difference between where the mouse is on the drag plane and 
    // where the origin of the object is on the drag plane
    private Vector3 offset;

    private Camera myMainCamera;

    void Start()
    {
        myMainCamera = Camera.main; // Camera.main is expensive ; cache it here
    }

    void OnMouseDown()
    {
        /*
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        xPos = ray.origin.x;
        yPos = ray.origin.y;
        */


        dragPlane = new Plane(myMainCamera.transform.forward, transform.position);
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition);

        float planeDist;
        dragPlane.Raycast(camRay, out planeDist);
        offset = transform.position - camRay.GetPoint(planeDist);

    }

    void OnMouseDrag()
    {
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition);

        float planeDist;
        dragPlane.Raycast(camRay, out planeDist);
        transform.position = camRay.GetPoint(planeDist) + offset;
    }

    private void Update()
    {
       if (transform.position.x > 9) 
        {
            transform.position = new Vector3(9f, transform.position.y);
        }
       if (transform.position.x < -9)
        {
            transform.position = new Vector3(-9f, transform.position.y);
        }
       if (transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, 5f);
        }
       if (transform.position.y < -5)
        {
            transform.position = new Vector3(transform.position.x, -5f);
        }
    }

}

