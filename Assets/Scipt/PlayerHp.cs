using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    public int MaxHp = 5;
    public int CurrentHp;
    public float timeNodamage;
    public float timedamage = 4;
    public bool damage;
    [SerializeField] GameObject gameOver;

    void Start()
    {
        CurrentHp = MaxHp;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            if(timeNodamage > timedamage)
            {
                CurrentHp = CurrentHp - 1;
                timeNodamage = 0;
            }
            if(CurrentHp == 0)
            {
                Time.timeScale = 0;
                gameOver.SetActive(true);

                if(Input.GetKeyDown("space"))
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }
    }

    void Update()
    {
        timeNodamage += Time.deltaTime;
    }
}
