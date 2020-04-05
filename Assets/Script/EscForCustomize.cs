using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscForCustomize : MonoBehaviour
{
    public int sceneToChangeTo;
    public GameObject puckPnl;
    public GameObject racketPnl;
    public GameObject arenaPnl;
    public GameObject wallsPnl;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ScanForESC();
    }


    void ScanForESC()
    {
        if (Input.GetKeyDown("escape") && puckPnl.activeInHierarchy == false && racketPnl.activeInHierarchy == false && arenaPnl.activeInHierarchy == false && wallsPnl.activeInHierarchy == false)
        {
            SceneManager.LoadScene(sceneToChangeTo);
        }
    }
}
