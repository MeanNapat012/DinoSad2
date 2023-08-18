using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public int MaxHp;
    public int CurrentHp;
    public float timeNodamage;
    public float timedamage = 4;
    public bool damage;

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
            
        }
    }

    void Update()
    {
        timeNodamage += Time.deltaTime;
    }
}
