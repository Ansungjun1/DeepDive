using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayCast : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] float MaxDistance = 5f;
    // Start is called before the first frame update
    public Canvas Key_E;

    GameObject hitObject;

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * MaxDistance, Color.blue, 0.3f);
        if(Physics.Raycast(transform.position, transform.forward, out hit, MaxDistance))
        {
            if (hit.collider.tag == "Test")
            {
                Key_E.GetComponent<Canvas>().enabled = true;

                if(Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<OnObject>().On();
                    hitObject = hit.collider.gameObject;
                }
                if(Input.GetKeyDown(KeyCode.Escape))
                {
                    hit.collider.GetComponent<OnObject>().Off();
                }
            }
        }

        else if (Key_E.GetComponent<Canvas>().enabled)
        {
            Key_E.GetComponent<Canvas>().enabled = false;
            if (hitObject)
            {
                hitObject.GetComponent<OnObject>().object_.SetActive(false);
                FindObjectOfType<PlayerCamera>().enabled = true;
                hitObject = null;
            }
        }
        else
        {
            Key_E.GetComponent<Canvas>().enabled = false;
        }
        
    }
}
