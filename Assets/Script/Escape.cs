using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Scan for ESC and go back to scene

public class Escape : MonoBehaviour {
    public int sceneToChangeTo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ScanForESC();
    }

    void ScanForESC()
    {
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(sceneToChangeTo);
        }
    }
}
