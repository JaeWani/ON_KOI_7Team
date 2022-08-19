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
        Story1Text = "��";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "����";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ ��";
        yield return new WaitForSecondsRealtime(0.5f);
        Story1Text = "������ �Բ�";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ �Բ� ��";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ �Բ� �� ��";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ �Բ� �� �ӿ�";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ �Բ� �� �ӿ� ��";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ �Բ� �� �ӿ� ���";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ �Բ� �� �ӿ� ��� ��";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ �Բ� �� �ӿ� ��� ����";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ �Բ� �� �ӿ� ��� ������";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ �Բ� �� �ӿ� ��� ��������";
        yield return new WaitForSecondsRealtime(0.25f);
        Story1Text = "������ �Բ� �� �ӿ� ��� �������ڴ�";
        Story1End2 = true;
        Debug.Log("���丮 1 ��");
    }
    IEnumerator Waiting2() 
    {
        Story2End = true;
        yield return new WaitForSeconds(0.5f);
        Story2Text = "��";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "���";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ��";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ���";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ��Ӵ�";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ��Ӵϲ�";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ��Ӵϲ� ��";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ��Ӵϲ� �Ҹ�";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ��Ӵϲ� �ҸӴ�";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ��Ӵϲ� �ҸӴ�";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ��Ӵϲ� �ҸӴ� ��";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ��Ӵϲ� �ҸӴ� ����";
        yield return new WaitForSeconds(0.25f);
        Story2Text = "��� �� ��Ӵϲ� �ҸӴ� ������";
        Story2End2 = true;
        Debug.Log("���丮 2 ��");
    }
    IEnumerator Waiting3() 
    {
        Story3End = true;
        yield return new WaitForSeconds(0.5f);
    }
}
