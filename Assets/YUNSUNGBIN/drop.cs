using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    [SerializeField]
    static private GameObject apple;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Drop();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    static void Drop()
    {
        Vector3 pos = new Vector3(0, 2f, 0);
        Instantiate(apple, pos, Quaternion.identity);
    }
}
