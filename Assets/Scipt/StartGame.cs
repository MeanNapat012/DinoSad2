using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    int GameStartChecker = 1;

    [SerializeField] GameObject gameStart;

    void Awake()
    {
        Time.timeScale = 0;
        gameStart.SetActive(true);
    }

    void Update()
    {
        if((GameStartChecker == 1) && (Input.GetKeyDown("space")))
        {
            gameStart.SetActive(false);
            Time.timeScale = 1;

            GameStartChecker = 0;
        }
    }
}
