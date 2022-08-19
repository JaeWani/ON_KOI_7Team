using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAi : MonoBehaviour
{

    Animator Anim;
    Rigidbody2D rigid;
    public int nextMove;
    Transform target;
    bool Airaycast = false;
    SpriteRenderer Spr;

    [Header("추격 속도")]
    [SerializeField] [Range(1f, 4f)] public float moveSpeed = 1f;
    [Header("근접 거리")]
    [SerializeField] [Range(0f, 3f)] float contactDistance = 2f;
    public static bool follow = false;
    // Start is called before the first frame update
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.freezeRotation = true;
        Anim = GetComponent<Animator>();
    }

    private void Start()
    {
        StartCoroutine("Think");
    }

    void Update()
    {
        Ai();
        Destroy();
        AnimationUpdate();
    }
    void Ai()
    {
        rigid.velocity = new Vector2(nextMove, rigid.velocity.y);

        Vector2 frontVec = new Vector2(rigid.position.x + nextMove, rigid.position.y);
        Debug.DrawRay(frontVec, Vector3.down, new Color(0, 1, 0));
        RaycastHit2D raycast = Physics2D.Raycast(frontVec, Vector3.down, 1);
        if (raycast.collider == null)
        {
            StopMove();
            nextMove *= -1;
        }
       
    }
    
    void AnimationUpdate()
    {
        if(nextMove <= -1)
        {
            Anim.SetBool("IsRun", true);
            Anim.SetBool("IsChange", false);
        }
        else if(nextMove == 0)
        {
            Anim.SetBool("IsRun", false);
            Anim.SetBool("IsRun2", false);
        }
        else if(nextMove >= 1)
        {
            Anim.SetBool("IsRun2", true);
            Anim.SetBool("IsChange", true);
        }
    }
  

    void Destroy()
    {
        if (GameManager.IsDay == true) 
        {
            Destroy(this.gameObject);
        }
    }
    public IEnumerator Think()
    {
        nextMove = Random.Range(-1, 2);

        float nextMoveTime = Random.Range(2f, 3f);

        yield return new WaitForSecondsRealtime(nextMoveTime);

        StartCoroutine("Think");
    }

    //public void FollowTarget()
    //{
    //    if (Vector2.Distance(transform.position, target.position) > contactDistance && follow)
    //    {
    //        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    //    }
    //    else
    //    {
    //        rigid.velocity = Vector2.zero;
    //    }
    //}

    public void StartMove()
    {
        StartCoroutine("Think");
    }

    public void StopMove()
    {
        StopCoroutine("Think");
    }
}
