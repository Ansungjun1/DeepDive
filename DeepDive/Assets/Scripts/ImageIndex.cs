using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageIndex : MonoBehaviour
{
    public Image img;
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
    }

    public void changeImg()
    {
        index++;
        if (index == 4)
            index = 0;

        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z -= 90f;

        transform.eulerAngles = currentRotation;

        Vector3 imgRotation = img.transform.eulerAngles;
        imgRotation.z += 90f;

        img.transform.eulerAngles = imgRotation;

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
