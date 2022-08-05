using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{



    [SerializeField]
    float TimeCounts = 5;
    [SerializeField]
    Text TimeCountText;

    public int DaySecondCounts = 0;
    public int NightSecondCounts = 0;

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
        StartCoroutine(UI());
    }

    void Update()
    {
        ChangeBackGrounds();
    }
    void ChangeBackGrounds() 
    {
        if (IsDay == true && IsNight == false)
        {
            BackGrounds.sprite = DayBackGround;
            TimeCountText.text = "시간  :  " + DaySecondCounts;

        }

        else if (IsDay == false && IsNight == true)
        {
            BackGrounds.sprite = NightBackGround;
            TimeCountText.text = "시간  :  " + NightSecondCounts;
        }
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
    IEnumerator UI() 
    {
        yield return new WaitForSecondsRealtime(1);
        if (IsDay == true)
            DaySecondCounts++;
        else if (IsDay == false)
            DaySecondCounts = 0;

        if (IsNight == true)
            NightSecondCounts++;
        else if (IsNight == false)
            NightSecondCounts = 0;

            StartCoroutine(UI());
        
    }
}
