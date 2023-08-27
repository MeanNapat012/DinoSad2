using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public int MaxHp = 5;
    public int CurrentHp;
    public float timeNodamage;
    public float timedamage = 4;
    [SerializeField] TMP_Text displayHPText;
    GameOver gameOver;

    void Start()
    {
        CurrentHp = MaxHp;
        DisplayHP();
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
            
            DisplayHP();            
        }
    }

    void Update()
    {
        timeNodamage += Time.deltaTime;

        if(CurrentHp == 0)
        {
            gameOver = FindObjectOfType<GameOver>();
            gameOver.GameEnd();
        }
    }

    void DisplayHP()
    {
        displayHPText.text = "Health: " + CurrentHp;
    }
}
