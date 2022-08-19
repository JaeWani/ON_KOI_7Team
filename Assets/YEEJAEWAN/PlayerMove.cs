using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float PlayerSpeed = 5;
    public static float JumpPower = 250;
    Rigidbody2D RB;
    SpriteRenderer Spr;
    Animator Anim;

    public bool IsGlass = false;
    public static bool IsHide = false;
    bool Jumped = false;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Spr = GetComponent<SpriteRenderer>();
        Anim = GetComponent<Animator>();
    }

    void Update()
    {
        Jump();
        Move();
        Hide();
    }
    void FixedUpdate()
    {
        
    }
    void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        RB.AddForce(Vector2.right * h, ForceMode2D.Impulse);
        if (RB.velocity.x > PlayerSpeed)  
            RB.velocity = new Vector2(PlayerSpeed, RB.velocity.y); 
        else if (RB.velocity.x < PlayerSpeed * (-1)) 
            RB.velocity = new Vector2(PlayerSpeed * (-1), RB.velocity.y);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Spr.flipX = false;
            Anim.SetBool("IsWalk", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Spr.flipX = true;
            Anim.SetBool("IsWalk", true);
        }
        else 
        {
            Anim.SetBool("IsWalk", false);
        }
    }
    void Hide() 
    {

        if (IsGlass == true && Input.GetKeyDown(KeyCode.Q))
        {
            Glass.Sprr.sortingLayerName = "Glasss";
            Debug.Log("ÀÛµ¿Áß!!");
            IsHide = true;
        }
        else if (IsGlass == true && Input.GetKeyDown(KeyCode.E)) 
        {
            Glass.Sprr.sortingLayerName = "Default";
            IsHide = false;
        }
        else if (IsGlass == false)
        {
            Glass.Sprr.sortingLayerName = "Default";
            IsHide = false;
        }
        
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Glass")
            IsGlass = true;
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Glass")
            IsGlass = false;
    }

}

