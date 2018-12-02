using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StVeSpawner : MonoBehaviour {

    public GameObject[] enemypatterns;

    private float timebtwspawn;
    public float starttimebtwspawn;
    public float decreasetime;
    public float mintime = 0.65f;

    private void Update()
    {
        if (timebtwspawn <= 0)
        {
            int rand = Random.Range(0, enemypatterns.Length);
            Instantiate(enemypatterns[rand], transform.position, Quaternion.identity);
            timebtwspawn = starttimebtwspawn;
            if (starttimebtwspawn > mintime)
            {
                starttimebtwspawn -= decreasetime;
            }

        }

        else
        {
            timebtwspawn -= Time.deltaTime;
        }
    }
}
