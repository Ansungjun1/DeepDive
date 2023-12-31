using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    public GameObject fade;

    public GameObject[] img;
    int index = 0;

    public GameObject text;


    private void Start()
    {
        FadeOut();
    }

    public void FadeOut()
    {
        fade.GetComponent<Animator>().SetTrigger("Fade");

        text.SetActive(false);    
    }
    public void ChangeImg()
    {
        StartCoroutine(wait());

        FadeOut();
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);

        if(index == img.Length - 1)
        {
            SceneManager.LoadScene(1);
        }

        img[index].SetActive(false);
        index++;
    }
}
