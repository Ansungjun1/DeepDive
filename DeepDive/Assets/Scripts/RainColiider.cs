using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainColiider : MonoBehaviour
{
    public float pos;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "rain")
        {
            other.transform.position = new Vector3(other.transform.position.x, pos, other.transform.position.z);
        }
    }
}
