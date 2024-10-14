using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 3f; 
    private Rigidbody2D rb;
    public bool isDead = false;
    public ScoreManager scoreManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    void Update()
    {
        if (!isDead)
        {
            Control();
        }
    }


    void Control()
    {
        // PC Control
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        // Mobile Control
        if (Input.touchCount > 0) 
        {
            Touch touch = Input.GetTouch(0); 

            if (touch.phase == TouchPhase.Began)
            {
                Jump(); 
            }
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreManager.addScore();
    }
}
