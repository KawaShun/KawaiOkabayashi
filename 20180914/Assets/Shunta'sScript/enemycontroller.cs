using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0f, 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f, -1.0f);
        }

    }
}
