using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    bool isSwim = false;

    [SerializeField]
    private float walkSpeed;

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
        }
        else
        {
            _velocity = new Vector3(_moveDirX, 0, _moveDirZ);

            _velocity = Camera.main.transform.TransformDirection(_velocity) * swimSpeed;
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
