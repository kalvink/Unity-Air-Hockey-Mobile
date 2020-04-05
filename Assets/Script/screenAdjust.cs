using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenAdjust : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Camera.main.aspect = 1080f / 1920f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
