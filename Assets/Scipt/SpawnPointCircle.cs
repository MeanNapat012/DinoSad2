using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointCircle : MonoBehaviour
{
    public GameObject Circle;
    public GameObject[] SpawnPoint;
    public float time;
    public float timeSpawn;
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time > timeSpawn)
        {
            time = 0;
            int randomNum = Random.Range(0,2);
            Instantiate(Circle, SpawnPoint[randomNum].transform.position, Quaternion.identity); 
        }
    }
}
