using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    bool isSwim = false;

    [SerializeField]
    private float walkSpeed;
    float soundFloat = 0f;
    [SerializeField]
    private float swimSpeed;

    Rigidbody myRigid;

    private void Start()
    {
        myRigid = transform.GetComponent<Rigidbody>();


    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        float _moveDirX = Input.GetAxisRaw("Horizontal");
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        

        Vector3 _velocity;
        if (!isSwim)
        {
            

            Vector3 _moveHorizontal = transform.right * _moveDirX;
            Vector3 _moveVertical = transform.forward * _moveDirZ;

            

            _velocity = (_moveHorizontal + _moveVertical).normalized * walkSpeed;

            if(_moveDirX + _moveDirZ != 0)
            {
                soundFloat += Time.deltaTime;

                if(soundFloat > 0.5f)
                {
                    soundFloat -= 0.5f;

                    FindObjectOfType<AudioManager>().Play(0);
                }
            }
        }
        else
        {
            _velocity = new Vector3(_moveDirX, 0, _moveDirZ);

            _velocity = Camera.main.transform.TransformDirection(_velocity) * swimSpeed;

            if (_moveDirX + _moveDirZ != 0)
            {
                soundFloat += Time.deltaTime;

                if (soundFloat > 0.5f)
                {
                    soundFloat -= 0.5f;

                    FindObjectOfType<AudioManager>().Play(1);
                }
            }
        }
        

        myRigid.MovePosition(transform.position + _velocity * Time.deltaTime);
    }



    public void GetSwim()
    {
        isSwim = true;

        GetComponent<Rigidbody>().useGravity = false;
        StopAllCoroutines();
    }

    public void GetOutSwim()
    {
        StartCoroutine(outSwim());
    }

    IEnumerator outSwim()
    {
        yield return new WaitForSeconds(1f);

        isSwim = false;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
