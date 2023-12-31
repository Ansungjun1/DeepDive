using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    [SerializeField]
    Transform[] myChild;
    float[] myChild_Z = new float[60];

    private void Start()
    {
        for (int i = 0; i < myChild.Length; i++)
        {
            myChild_Z[i] = Random.Range(100, 400);
        }
    }

    private void Update()
    {
        for(int i = 0; i < myChild.Length; i++)
        {
            myChild[i].Translate(new Vector3(0, -1, 0) * myChild_Z[i] * Time.deltaTime);
        }
    }
}
