using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Open or Close [Settings] Panel in Main Menu Scene


public class MenuSettings : MonoBehaviour {
    public GameObject mnuSettings;

    // Use this for initialization
    void Start() {
        mnuSettings.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update() {
    ScanForSettingsStroke();
    }

    public void SettingsButton(bool showSettings)
    {
        if (showSettings == true)
        {
            mnuSettings.gameObject.SetActive(true);
            Debug.Log("open settings");
        }
        if (showSettings == false)
        {
            mnuSettings.gameObject.SetActive(false);
            Debug.Log("close settings");
        }
    }
        void ScanForSettingsStroke()
        {
            if (Input.GetKeyDown("escape"))
            {
                mnuSettings.gameObject.SetActive(false);
                Debug.Log("close settings");
            }
        }
    }
