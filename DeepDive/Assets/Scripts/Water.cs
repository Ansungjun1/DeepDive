using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public static bool isWater = false;

    [SerializeField] private float waterDrag;
    private float originDrag;

    [SerializeField] private Color waterColor;
    [SerializeField] private float waterFogDensity;

    private Color originColor;
    private float originFogDesity;

    HPBar hpbar;

    // Start is called before the first frame update
    void Start()
    {
        originColor = RenderSettings.fogColor;
        originFogDesity = RenderSettings.fogDensity;

        originDrag = 0;

        hpbar = FindObjectOfType<HPBar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MainCamera")
        {
            GetWater(other.transform.parent);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            GetOutWater(other.transform.parent);
        }
    }

    private void GetWater(Transform _player)
    {
        isWater = true;
        _player.transform.GetComponent<Rigidbody>().drag = waterDrag;
        _player.transform.GetComponent<PlayerMove>().GetSwim();
        if (FindObjectOfType<HPBar>())
            FindObjectOfType<HPBar>().GetSwim();

        RenderSettings.fogColor = waterColor;
        RenderSettings.fogDensity = waterFogDensity;

        FindObjectOfType<AudioManager>().Play(2);
    }

    private void GetOutWater(Transform _player)
    {
        if(isWater)
        {
            isWater = false;
            _player.transform.GetComponent<Rigidbody>().drag = originDrag;
            _player.transform.GetComponent<PlayerMove>().GetOutSwim();

            if(FindObjectOfType<HPBar>())
                FindObjectOfType<HPBar>().GetOutSwim();

            RenderSettings.fogColor = originColor;
            RenderSettings.fogDensity = originFogDesity;

            FindObjectOfType<AudioManager>().Play(3);
            FindObjectOfType<AudioSub>().Play(1);
        }
       
    }
}
