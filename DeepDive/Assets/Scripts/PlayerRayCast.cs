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

    public Vector3 pos;
    public GameObject handle;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        pos = handle.transform.position;

        Debug.DrawRay(transform.position, transform.forward * MaxDistance, Color.blue, 0.3f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, MaxDistance))
        {
            if (hit.collider.tag == "Test")
            {
                Key_E.GetComponent<Canvas>().enabled = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<OnObject>().On();
                    hitObject = hit.collider.gameObject;
                }
                if(Input.GetKeyDown(KeyCode.Escape))
                {
                    hit.collider.GetComponent<OnObject>().Off();

                    if(Cursor.visible)
                    {
                        Cursor.lockState = CursorLockMode.Locked;
                        Cursor.visible = false;
                    }

                    return;
                }
            }
            if (hit.collider.tag == "TT")
            {
                Key_E.GetComponent<Canvas>().enabled = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<OnObjectDrop>().On();
                    Key_E.gameObject.SetActive(false);

                    FindObjectOfType<Last>().tag = "Finish";
                }
            }
            if(hit.collider.tag == "Finish")
            {
                //∞‘¿” ≥°
                FindObjectOfType<EndGame>().End();

                FindObjectOfType<PlayerCamera>().enabled = true;
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
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
        else
        {
            Key_E.GetComponent<Canvas>().enabled = false;
        }
        
    }
}
