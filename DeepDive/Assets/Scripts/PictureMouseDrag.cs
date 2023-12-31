using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PictureMouseDrag : MonoBehaviour
{
    float distance = 10.0f;

    float x;
    float y;

    bool isOn = false;

    public GameObject pos;

    private void Start()
    {
        x = pos.GetComponent<RectTransform>().position.x;
        y = pos.GetComponent<RectTransform>().position.y;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void Update()
    {
        if(isOn)
        {
            Vector3 mousePosition = new Vector3(x, pos.GetComponent<RectTransform>().anchoredPosition.y + 1, distance);

            if(pos.GetComponent<RectTransform>().anchoredPosition.y < 3000f)
                pos.GetComponent<RectTransform>().anchoredPosition = mousePosition;
        }
    }

    public void OnButton()
    {
        if(!isOn)
        {
            FindObjectOfType<AudioManager>().Play(9);
            isOn = true;
        }
    }
}