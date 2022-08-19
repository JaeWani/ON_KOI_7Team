using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTelling : MonoBehaviour
{
    

    public static bool IsStory = false;
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
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
