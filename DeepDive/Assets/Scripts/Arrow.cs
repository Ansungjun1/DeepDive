using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform[] arrow;
    public Vector3[] pos;

    private void Start()
    {
        StartCoroutine(ime());
    }

    IEnumerator ime()
    {
        yield return new WaitForSeconds(1f);

        for (int i = 0; i < arrow.Length; i++)
        {
            if(i < 3)
                arrow[i].rotation = Quaternion.Euler(pos[FindObjectOfType<Secret>().index[3]]);
            else
                arrow[i].rotation = Quaternion.Euler(0, -90, pos[FindObjectOfType<Secret>().index[3]].z);

        }

    }
}
