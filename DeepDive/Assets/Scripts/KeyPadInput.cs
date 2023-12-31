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

    public GameObject Door;

    public GameObject Sea;

    // Update is called once per frame
    void Update()
    {
        //key = new int[4];
        secret = FindObjectOfType<Secret>();
    }

    public void ChooseNum(int num)
    {
        if(index < 4)
        {
            number[index].text = num.ToString();
            key[index] = num;

            index++;

            FindObjectOfType<AudioManager>().Play(5);
        }
    }

    public void ClearNum()
    {
        if(index > 0)
        {
            index--;
            number[index].text = "_";
            key[index] = 0;

            FindObjectOfType<AudioManager>().Play(5);
        }
    }

    public void EndNum()
    {
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

                    FindObjectOfType<AudioManager>().Play(6);

                    return;
                }
            }
            // ¼º°ø
            Door.GetComponent<Animator>().SetTrigger("Open");
            this.gameObject.SetActive(false);
            Sea.GetComponent<Animator>().SetTrigger("Water");

            FindObjectOfType<AudioManager>().Play(7);
            FindObjectOfType<AudioSub>().Play(0);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            GameObject.FindGameObjectWithTag("Respawn").GetComponent<OnObjectDrop>().enabled = true;
            GameObject.FindGameObjectWithTag("light").GetComponent<Light>().enabled = true;


        }
    }
}
