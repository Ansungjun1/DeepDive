using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    bool isOn = false;

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            if(isOn)
                Destroy(this.gameObject);
        }
    }

    public void isOnOn()
    {
        isOn = true;
    }
}
