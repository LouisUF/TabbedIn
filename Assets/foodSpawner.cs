using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodSpawner : MonoBehaviour
{
    public GameObject food1;
    public GameObject food2;
    public GameObject food3;
    public GameObject food4;
    public GameObject food5;
    public GameObject food6;
    public int flatTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartWavesRoutine");
        flatTime = 8;
    }

    private IEnumerator StartWavesRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(flatTime + Random.Range(1, 5));
            var wanted = Random.Range(-2.2f, 2.2f);
            var position = new Vector3(transform.position.x + wanted, transform.position.y);
            int enemy = Random.Range(1, 7);
            if (enemy == 1)
            {
                GameObject Food = Instantiate(food1, position, transform.rotation);
                Food.transform.parent = gameObject.transform;
            }
            else if (enemy == 2)
            {
                GameObject Food = Instantiate(food2, position, transform.rotation);
                Food.transform.parent = gameObject.transform;
            }
            else if (enemy == 3)
            {
                GameObject Food = Instantiate(food3, position, transform.rotation);
                Food.transform.parent = gameObject.transform;
            }
            else if (enemy == 4)
            {
                GameObject Food = Instantiate(food4, position, transform.rotation);
                Food.transform.parent = gameObject.transform;
            } else if (enemy == 5)
            {
                GameObject Food = Instantiate(food5, position, transform.rotation);
                Food.transform.parent = gameObject.transform;
            } else if (enemy == 6)
            {
                GameObject Food = Instantiate(food6, position, transform.rotation);
                Food.transform.parent = gameObject.transform;
            }
        }
    }
}
