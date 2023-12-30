using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PictureMouseDrag : MonoBehaviour, IDragHandler
{
    float distance = 10.0f;

    float x;
    float y;

    bool isOn = false;

    private void Start()
    {
        x = GetComponent<RectTransform>().position.x;
        y = GetComponent<RectTransform>().position.y;
    }

    private void Update()
    {
        if(isOn)
        {
            Vector3 mousePosition = new Vector3(x, GetComponent<RectTransform>().anchoredPosition.y + 1, distance);

            if(GetComponent<RectTransform>().anchoredPosition.y < 3000f)
                GetComponent<RectTransform>().anchoredPosition = mousePosition;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(!isOn)
        {
            Vector3 mousePosition = new Vector3(x, Input.mousePosition.y, distance);

            if (mousePosition.y >= y)
            {
                GetComponent<RectTransform>().anchoredPosition = mousePosition;

                if (mousePosition.y > 1200)
                {
                    GetComponent<RectTransform>().anchoredPosition = mousePosition;

                    isOn = true;
                }
            }
            else
            {
                mousePosition.y = 545f;
            }
        }
    }
}