using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject gameStart;

    void Awake()
    {
        Time.timeScale = 0;
        gameStart.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            gameStart.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
