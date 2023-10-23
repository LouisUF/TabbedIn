using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
    public string sceneToLoad; // The name of the scene to load when clicked.
    public float clickRadius = 1.0f; // The radius around the GameObject where a click will trigger the scene change.
    public GameObject targetObject; // The GameObject to interact with.

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click.
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector3 objectPosition = targetObject.transform.position;
            float distance = Vector2.Distance(new Vector2(mousePosition.x, mousePosition.y), new Vector2(objectPosition.x, objectPosition.y));

            if (distance <= clickRadius)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}
