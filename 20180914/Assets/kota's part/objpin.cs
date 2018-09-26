using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objpin : MonoBehaviour {

	void update()
	{
		Debug.Log("true");
	}
	void OntriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "ball") {
			//hit = true;	
			Debug.Log("hitpin");
			Destroy(this.gameObject);
            
		}
	}
}
