using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnpointTriagle : MonoBehaviour
{
    public GameObject SpawnPointTg;
    public GameObject[] Triangle;
    public float timeTg;
    public float timeSpawnTg;
    void Start()
    {
        
    }

    void Update()
    {
        timeTg += Time.deltaTime;

        if(timeTg > timeSpawnTg)
        {
            timeTg = 0;
            int randNum = Random.Range(0,4);
            Instantiate(Triangle[randNum], SpawnPointTg.transform.position, Quaternion.identity);
        }
    }
}
