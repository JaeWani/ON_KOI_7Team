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

        if (Albedo > 0.7f)
        {
            Albedo = 0.699999f;
        }
        else if (Albedo <= 0) 
        {
            Albedo = 0;
        }



        if (StoryTelling.IsStory == true )
        {
            if (StoryTelling.StoryEnd == false)
            {
                Albedo += 0.001f;
            }
            else if (StoryTelling.StoryEnd == true)
            {
                Albedo -= 0.001f;
            }
        }
      
        GameObject Me = GameObject.Find("Canvas/StoryTelling");
        Color color = Me.GetComponent<Image>().color;
        color.a = Albedo;
        Me.GetComponent<Image>().color = color;
    }
}
