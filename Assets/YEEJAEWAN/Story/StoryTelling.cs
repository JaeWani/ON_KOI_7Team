using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTelling : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer BackGrounds;

    [SerializeField]
    Sprite story2;

    public static bool IsStory2 = false;

    public static bool StoryEnd = false;

    public static bool IsStory = false;
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsStory = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && StoryEnd == true) 
        {
            BackGrounds.sprite = story2;
            Debug.Log("asd");
            IsStory2 = true;
        }
    }
    void Story()
    {
        
    }
    IEnumerator Wait() 
    {
        yield return new WaitForSecondsRealtime(5);
        IsStory = true;
    }
}
