using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBullet : MonoBehaviour
{
    public GameObject[] bullet;
    int index;

    public GameObject Cabinet;

    // Start is called before the first frame update
    void Start()
    {
        index = bullet.Length;
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
            //น฿ป็
        }
    }
}
