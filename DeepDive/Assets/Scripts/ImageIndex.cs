using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageIndex : MonoBehaviour
{
    public Sprite[] img;
    [SerializeField]
    int index = 0;
    public int myIndex;
    public bool same = false;

    private void Start()
    {
        if (myIndex == index)
        {
            FindObjectOfType<CheckWASD>().Check();
            same = true;
        }
            
        GetComponent<Image>().sprite = img[index];
    }

    public void changeImg()
    {
        index++;
        if (index == 4)
            index = 0;

        GetComponent<Image>().sprite = img[index];

        if (myIndex == index)
        {
            FindObjectOfType<CheckWASD>().Check();
            same = true;
        }
            
        else if(same)
        {
            FindObjectOfType<CheckWASD>().NoCheck();
            same = false;
        }
        else
        {
            same = false;
        }
            
    }
}
