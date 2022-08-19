using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public static bool appleDrop = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && PlayerMove.IsHide == false)
        {
                appleDrop = true;
                Debug.Log("true");
            //if (Input.GetKey(KeyCode.T))
            //{
            //}
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        appleDrop = false;
    }
}
