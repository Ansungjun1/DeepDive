using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakStair : MonoBehaviour
{
    public GameObject[] stair;

    private void Start()
    {
        Break();
    }

    public void Break()
    {
        for(int i = 0; i < 3; i++)
        {
            stair[i].GetComponent<Rigidbody>().useGravity = true;
            stair[i].GetComponent<Rigidbody>().isKinematic = false;
            stair[i].GetComponent<Rigidbody>().mass = 50;
        }

    }
}
