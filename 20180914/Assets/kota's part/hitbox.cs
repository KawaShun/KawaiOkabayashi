using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox : MonoBehaviour {
	public bool hit=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OntriggerStay(Collider other)
		{
			if (other.gameObject.tag == "wall")
			{
			hit = true;	
			}
		else
		{

			hit = false;
			
		}
}
}
