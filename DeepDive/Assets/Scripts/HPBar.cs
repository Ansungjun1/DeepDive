using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    public RectTransform hp;
    // Start is called before the first frame update

    bool isSwim = false;

    private void Update()
    {
        if(isSwim)
        {
            hp.sizeDelta = new Vector2(hp.rect.width, hp.rect.height + (Time.deltaTime * 40f));
        }
    }

    public void GetSwim()
    {
        GetComponent<Canvas>().enabled = true;
        isSwim = true;
    }

    public void GetOutSwim()
    {
        GetComponent<Canvas>().enabled = false;
        hp.sizeDelta = new Vector2(hp.rect.width, 0);
        isSwim = false;
    }
}
