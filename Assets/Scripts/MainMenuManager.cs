using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [Header("Music Button")]
    public GameObject musicButtonOn;
    public GameObject musicButtonOff;

    public bool musicIsOn;
    public bool musicIsOff;
    public void Awake()
    {
        //musicIsOn = true;
    }
    void Start()
    {
        
    }

    void Update()
    {
        IconMusic();
    }

    public void MusicButtonON()
    {
        musicIsOn = false;
        AudioListener.pause = true;
    }

    public void MusicButtonOff()
    {
        musicIsOn = true;
        AudioListener.pause = false;

    }

    public void MusicButton(string type)
    {
        switch(type)
        {
            case "On":
                musicIsOn = false;
                AudioListener.pause = true;
                break;
            case "Off":
                musicIsOn = true;
                AudioListener.pause = false;
                break;
        }
    }

    public void IconMusic()
    {
        if (musicIsOn == true)
        {
            musicButtonOn.gameObject.SetActive(true);
            AudioListener.pause = false;
            //musicBtnOff.gameObject.SetActive(false);
        }
        else
            musicButtonOn.gameObject.SetActive(false);

        if (musicIsOn == false)
        {
            //musicBtnOn.gameObject.SetActive(false);
            musicButtonOff.gameObject.SetActive(true);
            AudioListener.pause = true;
        }
        else
            musicButtonOff.gameObject.SetActive(false);
    }
}
