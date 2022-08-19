using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryText : MonoBehaviour
{
    
    public bool Story1End = false;
    public bool Story2End = false;
    public bool Story3End = false;
    public bool Story4End = false;

    public bool Story1End2 = false;
    public bool Story2End2 = false;
    public bool Story3End2 = false;
    public bool Story4End2 = false;

    public Text Story1;
    public Text Story2;
    public Text Story3;
    public Text Story4;

    public string Story1Text;
    public string Story2Text;
    public string Story3Text;
    public string Story4Text;

    void Start()
    {
        Story1.text = "";
        Story2.text = "";
        Story3.text = "";
        Story4.text = "";
    }

    void Update()
    {
        Story1.text = Story1Text;
        Story2.text = Story2Text;
        Story3.text = Story3Text;
        Story4.text = Story4Text;
        if (StoryTelling.IsStory == true && Story1End == false)
            StartCoroutine(Waiting());

        if (StoryTelling.IsStory == true && Story1End2 == true && Story1End == true && Story2End == false) 
            StartCoroutine(Waiting2());

        if (StoryTelling.IsStory == true && Story2End2 ==true && Story2End == true && Story3End == false )
            StartCoroutine(Waiting3());
    }
    IEnumerator Waiting() 
    {
        Story1End = true;
        yield return new WaitForSecondsRealtime(0.5f);
        Story1Text = "엄";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함";
        yield return new WaitForSecondsRealtime(0.5f);
        Story1Text = "엄마와 함께";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함께 숲";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함께 숲 속";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함께 숲 속에";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함께 숲 속에 살";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함께 숲 속에 살던";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함께 숲 속에 살던 빨";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함께 숲 속에 살던 빨간";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함께 숲 속에 살던 빨간모";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함께 숲 속에 살던 빨간모자";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "엄마와 함께 숲 속에 살던 빨간모자는";
        Story1End2 = true;
        Debug.Log("스토리 1 끝");
    }
    IEnumerator Waiting2() 
    {
        Story2End = true;
        yield return new WaitForSeconds(0.5f);
        Story2Text = "어";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 ";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어머";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어머니";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어머니께";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어머니께 할";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어머니께 할머";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어머니께 할머니";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어머니께 할머니";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어머니께 할머니 간";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어머니께 할머니 간병";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "어느 날 어머니께 할머니 간병을";
        Story2End2 = true;
        Debug.Log("스토리 2 끝");
    }
    IEnumerator Waiting3() 
    {
        Story3End = true;
        yield return new WaitForSeconds(0.5f);
    }
}
