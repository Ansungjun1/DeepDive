using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckWASD : MonoBehaviour
{
    [SerializeField]
    int index = 0;
    public Text text;
    public void Check()
    {
        index++;
        if(index == 4)
        {
            text.enabled = true;
        }
    }

    public void NoCheck()
    {
        index--;

        text.enabled = false;
    }
}
