using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPadInput : MonoBehaviour
{
    public Text[] number;
    [SerializeField]
    int[] key;
    int index = 0;

    Secret secret;

    // Update is called once per frame
    void Update()
    {
        //key = new int[4];
        secret = FindObjectOfType<Secret>();
    }

    public void ChooseNum(int num)
    {
        number[index].text = num.ToString();
        key[index] = num;

        index++;

        if (index == 4)
        {
            for (int i = 0; i < 4; i++)
            {
                Debug.Log(secret.index[i] + " " + key[i]);
                if (secret.index[i] != key[i])
                {
                    number[0].text = "_";
                    number[1].text = "_";
                    number[2].text = "_";
                    number[3].text = "_";

                    index = 0;
                    return;
                }
            }
            // ¼º°ø


        }
    }
}
