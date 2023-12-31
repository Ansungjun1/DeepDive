using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    bool isOn = false;
    public void End()
    {
        if(!isOn)
        {
            this.GetComponent<Animator>().SetTrigger("End");
            FindObjectOfType<HPBar>().gameObject.SetActive(false);
            isOn = true;
        }
    }

    public void Exittt()
    {
        Application.Quit();
    }
}
