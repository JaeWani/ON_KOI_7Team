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
            Debug.Log("���丮 1����");
        }
        else if (Story1End2 == true && Story2End2 == false && Story2End == false)
        {
            Story2End = true;
            StartCoroutine(Waiting2());
            Debug.Log("���丮 2����");
        }
        else if (Story1End2 == true && Story2End2 == true && Story3End2 == false && Story3End == false)
        {
            Story3End = true;
            StartCoroutine(Waiting3());
            Debug.Log("���丮 3����");
        }
        else if (Story1End2 == true && Story2End2 == true && Story3End2 == true && Story3End == true && Story4End == false)
        {
            Story4End = true;
            StartCoroutine(Waiting4());
            Debug.Log("���丮 4����");
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
            Story1Text = "��";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "����";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ ��";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ�";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ� ��";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ� �� ��";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ� �� �ӿ�";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ� �� �ӿ� ��";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ� �� �ӿ� ���";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ� �� �ӿ� ��� ��";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ� �� �ӿ� ��� ����";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ� �� �ӿ� ��� ������";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ� �� �ӿ� ��� ��������";
            yield return new WaitForSecondsRealtime(0.1f);
            Story1Text = "������ �Բ� �� �ӿ� ��� �������ڴ�";
        
        Story1End2 = true;
        Debug.Log("���丮 1 ��");
    }
    IEnumerator Waiting2() 
    {
        Story2End = true;
        yield return new WaitForSecondsRealtime(0.5f);
        Story2Text = "��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "���";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ���";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ��Ӵ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ��Ӵϲ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ��Ӵϲ� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ��Ӵϲ� �Ҹ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ��Ӵϲ� �ҸӴ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ��Ӵϲ� �ҸӴ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ��Ӵϲ� �ҸӴ� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ��Ӵϲ� �ҸӴ� ����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story2Text = "��� �� ��Ӵϲ� �ҸӴ� ������";
        Story2End2 = true;
        Debug.Log("���丮 2 ��");
    }
    IEnumerator Waiting3() 
    {
        Story3End = true;
        yield return new WaitForSecondsRealtime(0.5f);
        Story3Text = "��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "��Ź";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "��Ź��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "��Ź�ް�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "��Ź�ް� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "��Ź�ް� �Ǿ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "��Ź�ް� �Ǿ���";
        yield return new WaitForSecondsRealtime(0.1f);
        Story3Text = "��Ź�ް� �Ǿ����.";
        yield return new WaitForSecondsRealtime(0.5f);
        Story3End2 = true;
        Debug.Log("���丮 3 ��");
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
        Story5Text = "��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "������";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "��������";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ������";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ������ ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ������ ����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ������ ���밡 ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ������ ���밡 ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ������ ���밡 ��Ÿ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ������ ���밡 ��Ÿ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ������ ���밡 ��Ÿ����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story5Text = "�������ڴ� �� �ӿ� ������ ���밡 ��Ÿ���ٴ�";
       
        yield return new WaitForSecondsRealtime(0.1f);
        Story4End2 = true;
    }
    IEnumerator Wating5() {
        Story5End = true;
        yield return new WaitForSecondsRealtime(0.5f);
        Story6Text =  "��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "���";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ���";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ��� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ��� ���� ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ��� ���� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ��� ���� �ǻ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ��� ���� �ǻ���";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ��� ���� �ǻ�����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ��� ���� �ǻ����� �ϰ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ��� ���� �ǻ����� �ϰ� ";
        yield return new WaitForSecondsRealtime(0.1f);
        Story6Text = "��Ӵ��� ���� �ǻ����� �ϰ� ��";
        Story5End2 = true;
    }
    IEnumerator Wating6()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Story7Text = "��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�Ҹ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�ҸӴ�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�ҸӴ���";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�ҸӴ��� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�ҸӴ��� ����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�ҸӴ��� ������ ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�ҸӴ��� ������ ����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�ҸӴ��� ������ ���� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�ҸӴ��� ������ ���� ����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�ҸӴ��� ������ ���� ������";
        yield return new WaitForSecondsRealtime(0.1f);
        Story7Text = "�ҸӴ��� ������ ���� ��������";
        Story6End2 = true;
    }
    IEnumerator Wating7()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Story8Text = "��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰���";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰�����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰����� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰����� �ű�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰����� �ű��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰����� �ű�� ��";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰����� �ű�� ����";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰����� �ű�� ������";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰����� �ű�� �����߾�";
        yield return new WaitForSecondsRealtime(0.1f);
        Story8Text = "�߰����� �ű�� �����߾��.";
        yield return new WaitForSecondsRealtime(3);
        Story7End2 = true;
    }
    IEnumerator End() 
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(2);
    }
}
