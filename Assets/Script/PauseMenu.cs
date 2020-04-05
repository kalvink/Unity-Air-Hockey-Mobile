using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public Canvas pauseMenu;
    public GameObject victory;
    public GameObject defeat;
    public GameObject settings;


    // Use this for initialization
    void Start()
    {
        pauseMenu.gameObject.SetActive(false);
        settings.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
        {
        ScanForKeyStroke();
        ScanForSettingsStroke();
        }

    void ScanForKeyStroke()
    {
        if (Input.GetKeyDown("escape") && (settings.gameObject.activeInHierarchy == false))
        {
            if (victory.gameObject.activeInHierarchy == false && defeat.gameObject.activeInHierarchy == false)
            {
                if (pauseMenu.gameObject.activeInHierarchy == false)
                {
                    Time.timeScale = 0;
                    pauseMenu.gameObject.SetActive(true);
                    Debug.Log("pause");

                }
                else
                {
                    Time.timeScale = 1;
                    pauseMenu.gameObject.SetActive(false);
                    Debug.Log("resume");

                }
            }
        }
    }

    public void ResumeButton(bool resumeGame) {
        if (resumeGame == true) {
            Time.timeScale = 1;
            pauseMenu.gameObject.SetActive(false);
            Debug.Log("resume");
        }
        
    }

    public void SettingsButton(bool showSettings)
    {
        if (showSettings == true)
        {
            settings.gameObject.SetActive(true);
            Debug.Log("open settings");
        }
        if (showSettings == false)
        {
            settings.gameObject.SetActive(false);
            Debug.Log("close settings");
        }


    }

    void ScanForSettingsStroke() {
        if (Input.GetKeyDown("escape"))
        {
            settings.gameObject.SetActive(false);
            Debug.Log("close settings");
        }
    }


}