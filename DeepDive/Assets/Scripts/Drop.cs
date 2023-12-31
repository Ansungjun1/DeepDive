using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject handle;

    public GameObject player;

    public bool isOn = false;


    private void Start()
    {
        handle.GetComponent<BoxCollider>().isTrigger = true;

        StartCoroutine(HideCursorr());
    }

    IEnumerator HideCursorr()
    {
        yield return new WaitForSeconds(0.5f);


        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        FindObjectOfType<PlayerCamera>().enabled = true;
    }


    public void Off()
    {
        handle.GetComponent<BoxCollider>().isTrigger = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        FindObjectOfType<PlayerCamera>().enabled = true;
    }


    private void Update()
    {
         handle.transform.position = player.GetComponent<PlayerRayCast>().pos;
    }

}
