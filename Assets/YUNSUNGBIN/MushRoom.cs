using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushRoom : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerMove_1.JumpPower *= 8;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerMove_1.JumpPower = 5;
        }
    }
}
