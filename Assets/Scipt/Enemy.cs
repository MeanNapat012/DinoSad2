using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeedEnemy = 5f;
    public float timer;
    public float timerdead;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timerdead)
        {
            Destroy(gameObject);
        }
        rb.velocity = Vector2.left * moveSpeedEnemy;
    }
}
