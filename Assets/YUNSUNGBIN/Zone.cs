using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            WolfAi.follow = true;
            transform.parent.GetComponent<WolfAi>().StopMove();
            Vector3 playerPos = collision.transform.position;
            if(playerPos.x > transform.position.x)
            {
                transform.parent.GetComponent<WolfAi>().nextMove = 2;
            }
            else if (playerPos.x < transform.position.x)
            {
                transform.parent.GetComponent<WolfAi>().nextMove = -2;
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            WolfAi.follow = false;
            transform.parent.GetComponent<WolfAi>().StartMove();
        }
    }

}
