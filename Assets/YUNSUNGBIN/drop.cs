using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public GameObject Apple;
    Collision2D collision;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    void Destroy()
    {
        if(Tree.appleDrop == false)
        {
            Destroy(this.gameObject);
        }
        else if(Tree.appleDrop == true)
        {
            Instantiate(Apple);
        }
    }
}