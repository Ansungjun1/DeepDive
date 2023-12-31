using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryText : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update


    bool isOn = false;

    public void OnText()
    {
        text.SetActive(true);
    }

    public void OnStory()
    {
        isOn = true;
    }

    public void FindStory()
    {
        if (isOn)
        {
            FindObjectOfType<Story>().ChangeImg();
            isOn = !isOn;
        }
    }
}
