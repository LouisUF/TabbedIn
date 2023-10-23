using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class sortingLayerManager : MonoBehaviour
{
    public GameObject parentTab;

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Canvas>().sortingLayerName = parentTab.GetComponent<SortingGroup>().sortingLayerName;
    }
}
