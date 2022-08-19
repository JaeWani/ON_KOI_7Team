using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int PlayerHP = 3;

    [SerializeField]
    RectTransform Chim;

    [SerializeField]
    GameObject Wolf;

    [SerializeField]
    Transform Position;

    [SerializeField]
    float TimeCounts = 10;
    [SerializeField]
    Text TimeCountText;

    public int DaySecondCounts = 0;
    public int NightSecondCounts = 0;

    public static bool IsDay = false;
    public static bool IsNight = false;

    [SerializeField]
    SpriteRenderer BackGrounds;
    
    [SerializeField]
    Sprite DayBackGround;
    [SerializeField]
    Sprite NightBackGround;
    void Start()
    {
        TimeCounts = 10;
        IsDay = true;
        IsNight = false;
        StartCoroutine(TimeCount());
        StartCoroutine(UI());
    }
    void SpawnWolf() 
    {
        if (IsDay == false && IsNight == true) 
        {
            Instantiate(Wolf,Position.position,Position.rotation);
        }
    }
    void Update()
    {
        ChangeBackGrounds();
        TimeUI();
    }
    void ChangeBackGrounds() 
    {
        if (IsDay == true && IsNight == false)
        {
            BackGrounds.sprite = DayBackGround;
            TimeCountText.text = "밤까지 남은 시간  :  " + DaySecondCounts;
        }

        else if (IsDay == false && IsNight == true)
        {
            BackGrounds.sprite = NightBackGround;
            TimeCountText.text = "낮까지 남은 시간  :  " + NightSecondCounts;
        }
    }
    void TimeUI() 
    {

        if (IsDay == true && IsNight == false)
        {
            Chim.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (IsDay == false && IsNight == true) 
        {
            Chim.rotation = Quaternion.Euler(180, 0 , 0);
        }
    }
    IEnumerator TimeCount()
    {
        yield return new WaitForSecondsRealtime(TimeCounts);
        IsDay = false;
        IsNight = true;
        SpawnWolf();
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
