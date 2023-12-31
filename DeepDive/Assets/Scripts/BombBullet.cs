using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBullet : MonoBehaviour
{
    public GameObject[] bullet;
    int index;

    public GameObject Cabinet;

    bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        index = bullet.Length;

        FindObjectOfType<AudioSub>().Play(2);
    }

    public void Shoot()
    {
        if(index > 0)
        {
            index--;
            bullet[index].SetActive(false);

            if (index == 0)
            {
                Cabinet.GetComponent<Animator>().SetTrigger("Bomb");
            }

            GetComponent<Animator>().SetTrigger("lever");
            isOn = true;

            Camera.main.GetComponent<Animator>().SetTrigger("Bomb");
            FindObjectOfType<AudioSub>().Play(3);
            FindObjectOfType<AudioManager>().Play(8);
            //น฿ป็
        }
    }
}
