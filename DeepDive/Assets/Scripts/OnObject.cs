using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnObject : MonoBehaviour
{
    public GameObject object_;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void On()
    {
        object_.SetActive(true);
        FindObjectOfType<PlayerCamera>().enabled = false;
    }

    public void Off()
    {
        object_.SetActive(false);
        FindObjectOfType<PlayerCamera>().enabled = true;
    }
}
