using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class clickManager : MonoBehaviour
{
    public List<GameObject> tabs;
    public GameObject tallWindow;
    private GameObject temp;
    public string topTab;
    private float xPos;
    private float yPos;
    private bool inRight;
    private bool inLeft;
    private bool inTop;
    private bool inBottom;
    public float xBufferDefault;
    public float yBufferDefault;
    public float xBufferTall;
    public float yBufferTall;
    private float xBuffer;
    private float yBuffer;
    private float xRelative;
    private float yRelative;

    public bool canDrag;
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            xPos = ray.origin.x;
            yPos = ray.origin.y;
            Debug.Log(xPos + " " + yPos);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                Debug.Log("CLICKED " + hit.collider.name);
                for (int i = 0; i < tabs.Count; i++)
                {
                    if (GameObject.ReferenceEquals(hit.collider.gameObject, tabs[i]))
                    {
                        /*
                        xRelative = xPos - tabs[tabs.Count -1].transform.position.x;
                        yRelative = yPos - tabs[tabs.Count - 1].transform.position.y;
                        Debug.Log(xRelative + " " + yRelative);

                        inRight = false;
                        inLeft = false;
                        inTop = false;
                        inBottom = false;
                        if (GameObject.ReferenceEquals(tabs[tabs.Count - 1], tallWindow))
                        {
                            xBuffer = xBufferTall;
                            yBuffer = yBufferTall;
                        }
                        else
                        {
                            xBuffer = xBufferDefault;
                            yBuffer = yBufferDefault;
                        }
                        if (xRelative < xBuffer)
                        {
                            inRight = true;
                        }
                        if (xRelative > -xBuffer)
                        {
                            inLeft = true;
                        }
                        if (yRelative < yBuffer)
                        {
                            inTop = true;
                        }
                        if (yRelative > -yBuffer)
                        {
                            inBottom = true;
                        }
                        if (!inRight || !inLeft || !inTop || !inBottom)
                        {
                            temp = tabs[i];
                            for (int j = i + 1; j < tabs.Count; j++)
                            {
                                tabs[j - 1] = tabs[j];
                            }
                            tabs[tabs.Count - 1] = temp;
                        }
                        */
                        temp = tabs[i];
                        for (int j = i + 1; j < tabs.Count; j++)
                        {
                            tabs[j - 1] = tabs[j];
                        }
                        tabs[tabs.Count - 1] = temp;
                    }
                }
                if (tabs.Count > 0)
                {
                    setTabLayers();
                }
            }
        }
        if (tabs.Count > 0)
        {
            topTab = tabs[tabs.Count - 1].name;
        }
        
    }

    public void setTabLayers()
    {
        for (int i = 0; i < tabs.Count; i++)
        {
            tabs[i].GetComponent<SortingGroup>().sortingLayerName = i.ToString();
        }
    }
}
