using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotSpeed = 500.0f;

    float mx;
    float my;

    GameObject player;

    private void Start()
    {
        player = FindObjectOfType<PlayerMove>().gameObject;
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        mx += h * rotSpeed * Time.deltaTime;
        my += v * rotSpeed * Time.deltaTime;

        if (my < -60.0f)
            my = -60.0f;
        if (my > 60.0f)
            my = 60.0f;


        transform.eulerAngles = new Vector3(-my, player.transform.eulerAngles.y, 0);
        player.transform.eulerAngles = new Vector3(0, mx, 0);
    }
}
