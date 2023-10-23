using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class germSpawner : MonoBehaviour
{
    public GameObject germ;
    public GameObject germ1;
    public GameObject germ2;

    public int flatTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartWavesRoutine");
        flatTime = 5;
    }

    private IEnumerator StartWavesRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(flatTime + Random.Range(3, 10));
            int enemy = Random.Range(1, 4);
            if (enemy == 1)
            {
                GameObject Germ = Instantiate(germ, transform.position, transform.rotation);
                Germ.transform.parent = gameObject.transform;
            }
            else if (enemy == 2)
            {
                GameObject Germ = Instantiate(germ1, transform.position, transform.rotation);
                Germ.transform.parent = gameObject.transform;
            }
            else if (enemy == 3)
            {
                GameObject Germ = Instantiate(germ2, transform.position, transform.rotation);
                Germ.transform.parent = gameObject.transform;
            }


        }
    }

}
