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
        //Move by Key
        float h = Input.GetAxisRaw("Horizontal");
        RB.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        //Max speed Right
        if (RB.velocity.x > PlayerSpeed)  //오른쪽으로 이동 (+) , 최대 속력을 넘으면 
            RB.velocity = new Vector2(PlayerSpeed, RB.velocity.y); //해당 오브젝트의 속력은 maxSpeed 

        //Max speed left
        else if (RB.velocity.x < PlayerSpeed * (-1)) // 왼쪽으로 이동 (-) 
            RB.velocity = new Vector2(PlayerSpeed * (-1), RB.velocity.y); //y값은 점프의 영향이므로 0으로 제한을 두
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

