using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckWASD : MonoBehaviour
{
    [SerializeField]
    int index = 0;
    public Text text;

    public Image clear;
    public void Check()
    {
        FindObjectOfType<AudioManager>().Play(10);
        index++;
        if(index == 4)
        {
            text.enabled = true;
            clear.enabled = true;
        }
    }

    public void NoCheck()
    {
        index--;
    }
}
