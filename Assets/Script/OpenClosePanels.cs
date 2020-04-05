using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Open or Close [Settings] Panel in Main Menu Scene


public class OpenClosePanels : MonoBehaviour
{
    public GameObject puckPnl;
    public GameObject racketPnl;
    public GameObject arenaPnl;
    public GameObject wallsPnl;
    public GameObject EscForCustomizeScript;



    // Use this for initialization
    void Start()
    {
        puckPnl.gameObject.SetActive(false);
        racketPnl.gameObject.SetActive(false);
        arenaPnl.gameObject.SetActive(false);
        wallsPnl.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        ScanForSettingsStroke();
    }

    public void PuckPanel(bool showSettings)
    {
        if (showSettings == true)
        {
            puckPnl.gameObject.SetActive(true);
            EscForCustomizeScript.GetComponent<EscForCustomize>().enabled = false;
            Debug.Log("Esc false");
        }
        if (showSettings == false)
        {
            puckPnl.gameObject.SetActive(false);
        }
    }
    public void RacketPanel(bool showSettings)
    {
        if (showSettings == true)
        {
            racketPnl.gameObject.SetActive(true);
            EscForCustomizeScript.GetComponent<EscForCustomize>().enabled = false;
            Debug.Log("Esc false");
        }
        if (showSettings == false)
        {
            racketPnl.gameObject.SetActive(false);
        }
    }
    public void ArenaPanel(bool showSettings)
    {
        if (showSettings == true)
        {
            arenaPnl.gameObject.SetActive(true);
            EscForCustomizeScript.GetComponent<EscForCustomize>().enabled = false;
            Debug.Log("Esc false");
        }
        if (showSettings == false)
        {
            arenaPnl.gameObject.SetActive(false);
        }
    }
    public void WallsPanel(bool showSettings)
    {
        if (showSettings == true)
        {
            wallsPnl.gameObject.SetActive(true);
            EscForCustomizeScript.GetComponent<EscForCustomize>().enabled = false;
            Debug.Log("Esc false");
        }
        if (showSettings == false)
        {
            wallsPnl.gameObject.SetActive(false);
        }
    }
    void ScanForSettingsStroke()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (puckPnl.activeInHierarchy == true)
            {
                Debug.Log("puck closed");
                puckPnl.gameObject.SetActive(false);
                EscForCustomizeScript.GetComponent<EscForCustomize>().enabled = true;
                Debug.Log("Esc true");
            }
            else if(racketPnl.activeInHierarchy == true)
            {
                Debug.Log("racket closed");
                racketPnl.gameObject.SetActive(false);
                EscForCustomizeScript.GetComponent<EscForCustomize>().enabled = true;
                Debug.Log("Esc true");
            }
            else if (arenaPnl.activeInHierarchy == true)
            {
                Debug.Log("arena closed");
                arenaPnl.gameObject.SetActive(false);
                EscForCustomizeScript.GetComponent<EscForCustomize>().enabled = true;
                Debug.Log("Esc true");
            }
            else if (wallsPnl.activeInHierarchy == true)
            {
                Debug.Log("walls closed");
                wallsPnl.gameObject.SetActive(false);
                EscForCustomizeScript.GetComponent<EscForCustomize>().enabled = true;
                Debug.Log("Esc true");
            }

        }
    }
}
