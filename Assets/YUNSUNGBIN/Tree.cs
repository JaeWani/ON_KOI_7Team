using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    bool isCollision = false;
    [SerializeField]
    public GameObject Apple;
    public static GameObject me;
    public static Transform tree;
    bool IsCoolTime = false;
    public static bool appleDrop = false;

    public void Start()
    {
        tree = GetComponent<Transform>();
        me = GetComponent<GameObject>();
    }

    private void Update()
    {
        Debug.Log(IsCoolTime);
        if(appleDrop == true)
        {
            Instantiate(Apple, tree.position, tree.rotation);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isCollision = true;
            if (IsCoolTime == false)
            {
                appleDrop = true;
                StartCoroutine(CoolTime());
            }
            Debug.Log("true");
        }
    }

    IEnumerator CoolTime()
    {
        appleDrop = false;

        IsCoolTime = true;

        yield return new WaitForSecondsRealtime(15);

        IsCoolTime = false;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        appleDrop = false;
        isCollision = false;
    }
}
