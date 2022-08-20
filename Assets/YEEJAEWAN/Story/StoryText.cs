using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryText : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer BackGrounds;

    [SerializeField]
    Sprite story2;

    public bool Story1End = false;
    public bool Story2End = false;
    public bool Story3End = false;
    public bool Story4End = false;
    public bool Story5End = false;
    public bool Story6End = false;
    public bool Story7End = false;
    public bool Story8End = false;

    public bool Story1End2 = false;
    public bool Story2End2 = false;
    public bool Story3End2 = false;
    public bool Story4End2 = false;
    public bool Story5End2 = false;
    public bool Story6End2 = false;
    public bool Story7End2 = false;
    public bool Story8End2 = false;

    public Text Story1;
    public Text Story2;
    public Text Story3;
    public Text Story4;
    public Text Story5;
    public Text Story6;
    public Text Story7;
    public Text Story8;

    public string Story1Text;
    public string Story2Text;
    public string Story3Text;
    public string Story4Text;
    public string Story5Text;
    public string Story6Text;
    public string Story7Text;
    public string Story8Text;

    void Start()
    {
        Story1.text = "";
        Story2.text = "";
        Story3.text = "";
        Story4.text = "";
        Story5.text = "";
        Story6.text = "";
        Story7.text = "";
        Story8.text = "";
    }

    void Update()
    {
        Story1.text = Story1Text;
        Story2.text = Story2Text;
        Story3.text = Story3Text;
        Story4.text = Story4Text;
        Story5.text = Story5Text;
        Story6.text = Story6Text;
        Story7.text = Story7Text;
        Story8.text = Story8Text;

        if (Story1End2 == false && Input.GetKeyDown(KeyCode.Space) && Story1End == false)
        {
            Story1End = true;
            StartCoroutine(Waiting());
            Debug.Log("스토리 1시작");
        }
        else if (Story1End2 == true && Story2End2 == false && Story2End == false)
        {
            Story2End = true;
            StartCoroutine(Waiting2());
            Debug.Log("스토리 2시작");
        }
        else if (Story1End2 == true && Story2End2 == true && Story3End2 == false && Story3End == false)
        {
            Story3End = true;
            StartCoroutine(Waiting3());
            Debug.Log("스토리 3시작");
        }
        else if (Story1End2 == true && Story2End2 == true && Story3End2 == true && Story3End == true && Story4End == false)
        {
            Story4End = true;
            StartCoroutine(Waiting4());
            Debug.Log("스토리 4시작");
        }
        else if (Story4End == true && Story4End2 == true && Story5End == false && Story5End2 == false)
        {
            Story5End = true;
            StartCoroutine(Wating5());
        }
        else if (Story5End == true && Story5End2 == true && Story6End == false && Story6End2 == false)
        {
            Story6End = true;
            StartCoroutine(Wating6());
        }
        else if (Story6End == true && Story6End2 == true && Story7End == false && Story7End2 == false) 
        {
            Story7End = true;
            StartCoroutine(Wating7());
        }

        if (Story7End2 == true)
        {
            StartCoroutine(End());
        }


        if (Story4End == true) 
        {
            Story1.text = " ";
            Story2.text = " ";
            Story3.text = " ";
            Story4.text = " ";
        }

     /*   if (StoryTelling.IsStory == true && Story1End == false)
            StartCoroutine(Waiting());

        if (StoryTelling.IsStory == true && Story1End2 == true && Story1End == true && Story2End == false) 
            StartCoroutine(Waiting2());

        if (StoryTelling.IsStory == true && Story2End2 == true && Story2End == true && Story3End == false)
            StartCoroutine(Waiting3());
        */

      /*  if (StoryTelling.IsStory2 == true) 
        {
            Story1.text = "";
            Story2.text = "";
            Story3.text = "";
            Story4.text = "";

            StoryTelling.IsStory2 = false;
        } */

     /*   if (StoryTelling.StoryEnd == true)
        {
            Story1.text = "";
            Story2.text = "";
            Story3.text = "";
            Story4.text = "";

      
        }*/

    }
    IEnumerator Waiting() 
    {
        Story1End = true;
       
            yield return new WaitForSecondsRealtime(1);
            Story1Text = "엄";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께 숲";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께 숲 속";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께 숲 속에";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께 숲 속에 살";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께 숲 속에 살던";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께 숲 속에 살던 빨";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께 숲 속에 살던 빨간";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께 숲 속에 살던 빨간모";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께 숲 속에 살던 빨간모자";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "엄마와 함께 숲 속에 살던 빨간모자는";
        
        Story1End2 = true;
        Debug.Log("스토리 1 끝");
    }
    IEnumerator Waiting2() 
    {
        Story2End = true;
        yield return new WaitForSecondsRealtime(0.5f);
        Story2Text = "어";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어머";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어머니";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어머니께";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어머니께 할";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어머니께 할머";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어머니께 할머니";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어머니께 할머니";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어머니께 할머니 간";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어머니께 할머니 간병";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "어느 날 어머니께 할머니 간병을";
        Story2End2 = true;
        Debug.Log("스토리 2 끝");
    }
    IEnumerator Waiting3() 
    {
        Story3End = true;
        yield return new WaitForSecondsRealtime(0.5f);
        Story3Text = "부";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "부탁";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "부탁받";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "부탁받게";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "부탁받게 되";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "부탁받게 되었";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "부탁받게 되었어";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "부탁받게 되었어요.";
        yield return new WaitForSecondsRealtime(0.5f);
        Story3End2 = true;
        Debug.Log("스토리 3 끝");
        StoryTelling.StoryEnd = true;
        yield return new WaitForSecondsRealtime(3);
        BackGrounds.sprite = story2;
        yield return new WaitForSecondsRealtime(5f);
        StoryTelling.StoryEnd = false;
    }
    IEnumerator Waiting4() 
    {
        Story1.text = " ";
        Story2.text = " ";
        Story3.text = " ";
        Story4.text = " ";
        yield return new WaitForSecondsRealtime(9);
        Story5Text = "빨";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무서";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무서운";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무서운 늑";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무서운 늑대";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무서운 늑대가 ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무서운 늑대가 나";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무서운 늑대가 나타";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무서운 늑대가 나타난";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무서운 늑대가 나타난다";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "빨간모자는 숲 속에 무서운 늑대가 나타난다는";
       
        yield return new WaitForSecondsRealtime(0.1f);
        Story4End2 = true;
    }
    IEnumerator Wating5() {
        Story5End = true;
        yield return new WaitForSecondsRealtime(0.5f);
        Story6Text =  "어";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니의";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니의 말";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니의 말을 ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니의 말을 되";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니의 말을 되새";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니의 말을 되새김";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니의 말을 되새김질";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니의 말을 되새김질 하고";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니의 말을 되새김질 하고난 ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "어머니의 말을 되새김질 하고난 후";
        Story5End2 = true;
    }
    IEnumerator Wating6()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Story7Text = "할";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머니";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머니의";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머니의 간";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머니의 간병";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머니의 간병을 위";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머니의 간병을 위한";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머니의 간병을 위한 여";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머니의 간병을 위한 여정";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머니의 간병을 위한 여정으";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "할머니의 간병을 위한 여정으로";
        Story6End2 = true;
    }
    IEnumerator Wating7()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Story8Text = "발";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸음";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸음을";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸음을 옮";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸음을 옮기";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸음을 옮기기";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸음을 옮기기 시";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸음을 옮기기 시작";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸음을 옮기기 시작했";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸음을 옮기기 시작했어";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "발걸음을 옮기기 시작했어요.";
        yield return new WaitForSecondsRealtime(3);
        Story7End2 = true;
    }
    IEnumerator End() 
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(2);
    }
}
