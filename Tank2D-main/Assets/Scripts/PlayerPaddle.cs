using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{

    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    private float moveSpeed = 100f;

    // Initializacja
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Akutalzacja co klatkę -> sterowanie myszką
    void Update()
    {
        
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        
        
    }
}