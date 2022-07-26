using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float PlayerSpeed = 5;
    public float JumpPower = 5;
    Rigidbody2D RB;

    bool Jumped = false;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
    }
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        RB.AddForce(Vector2.right * h, ForceMode2D.Impulse);
        if (RB.velocity.x > PlayerSpeed)  
            RB.velocity = new Vector2(PlayerSpeed, RB.velocity.y); 
        else if (RB.velocity.x < PlayerSpeed * (-1)) 
            RB.velocity = new Vector2(PlayerSpeed * (-1), RB.velocity.y); 
    }
    void Jump() 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && Jumped == false)
        {
            RB.AddForce(Vector2.up * JumpPower, ForceMode2D.Force);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor") 
        {
            Jumped = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Jumped = false;
        }
    }
}

