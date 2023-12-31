using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBG : MonoBehaviour
{
    public AudioClip[] arrAudio;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Play(int index)
    {
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().PlayOneShot(arrAudio[index], 0.8f);
    }
}
