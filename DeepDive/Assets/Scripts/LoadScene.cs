using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private void Start()
    {
        Screen.SetResolution(1920, 1080, false);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }
}
