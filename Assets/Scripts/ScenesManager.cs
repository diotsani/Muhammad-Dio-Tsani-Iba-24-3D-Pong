using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        
    }

    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
        Debug.Log("load scene " + scenename);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
