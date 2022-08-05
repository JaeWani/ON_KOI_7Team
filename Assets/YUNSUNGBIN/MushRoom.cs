using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushRoom : MonoBehaviour
{
    //Rigidbody2D rigid;
    //Animator animator;

    //public bool leftMove = false;
    //public bool rightMove = false;

    //float jumpPower = 15f;
    //bool jumping = false;
    //bool jumpState = false;

    //Vector2 jumpBlockPW = new Vector2(0, 35);
    //// Start is called before the first frame update
    //void Start()
    //{
    //    animator = gameObject.GetComponent<Animator>();
    //    rigid = gameObject.GetComponent<Rigidbody2D>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetButtonDown("jump") && !jumpState)
    //    {
    //        jumping = true;
    //        jumpState = true;
    //    }
    //    Jump();

    //}

    //void Jump()
    //{
    //    if (!jumping)
    //    {
    //        return;
    //    }
    //    rigid.velocity = Vector2.zero;
    //    Vector2 jumpVelocity = new Vector2(0, jumpPower);
    //    rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);
    //    jumping = false;
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        collision.gameObject.SetActive(false);
    //    }
    //    if(collision.CompareTag("JumpBlock") && rigid.velocity.y < 0)
    //    {
    //        rigid.AddForce(jumpBlockPW, ForceMode2D.Impulse);
    //    }
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.layer == 8 && (transform.position.y - collision.transform.position.y) > 0.5)
    //    {
    //        jumpState = false;
    //    }
    //}
}
