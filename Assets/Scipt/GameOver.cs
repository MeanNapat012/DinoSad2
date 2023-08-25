using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    public void GameEnd()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);

        if(Input.GetKeyDown("space"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
