using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    float TimeCounts = 5;


    public bool IsDay = false;
    public bool IsNight = false;

    [SerializeField]
    SpriteRenderer BackGrounds;
    
    [SerializeField]
    Sprite DayBackGround;
    [SerializeField]
    Sprite NightBackGround;
    void Start()
    {
        IsDay = true;
        IsNight = false;
        StartCoroutine(TimeCount());
    }

    void Update()
    {
        ChangeBackGrounds();
    }
    void ChangeBackGrounds() 
    {
        if (IsDay == true && IsNight == false)
            BackGrounds.sprite = DayBackGround;

        else if (IsDay == false && IsNight == true)
            BackGrounds.sprite = NightBackGround;
    }
    IEnumerator TimeCount()
    {
        yield return new WaitForSecondsRealtime(TimeCounts);
        IsDay = false;
        IsNight = true;
        yield return new WaitForSecondsRealtime(TimeCounts);
        IsDay = true;
        IsNight = false;
        StartCoroutine(TimeCount());
    }
}
