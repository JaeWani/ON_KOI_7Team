using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public float Albedo;
    void Start()
    {
        
    }

    void Update()
    {

        if (Albedo >= 0.7f) 
        {
            Albedo = 0.7f;
        }

        if (StoryTelling.IsStory == true) 
        {
            Albedo += Time.deltaTime;
            GameObject Me = GameObject.Find("Canvas/StoryTelling");
            Color color = Me.GetComponent<Image>().color;
            color.a = Albedo;
            Me.GetComponent<Image>().color = color;
        }

        
    }
}
