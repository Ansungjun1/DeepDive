using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnObjectDrop : MonoBehaviour
{
    public GameObject object_;

    bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        this.tag = "TT";
    }

    public void On()
    {
        object_.SetActive(true);
        isOn = true;
    }
}
