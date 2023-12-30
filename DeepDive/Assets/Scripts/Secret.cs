using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Secret : MonoBehaviour
{
    [SerializeField]
    public int[] index;

    [SerializeField]
    Text[] text;

    private void Start()
    {
        for(int i = 0; i < index.Length; i++)
        {
            index[i] = Random.Range(0, 10);

            text[i].text = index[i].ToString();
        }
    }
}
