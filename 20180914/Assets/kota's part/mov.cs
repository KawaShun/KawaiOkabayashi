using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public float power = 10;
    bool woaking = true;

	public float mx=0;
	public float mz=0;
    public GameObject pin;
    Vector3 me;
    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
		this.transform.Translate(mx, 0, mz);
        me = this.transform.position;

        if (Input.GetKey (KeyCode.LeftArrow) && woaking == true) {
			//  this.transform.Translate(-0.2f, 0, 0);
		//	mx -= Mathf.Clamp (0.003f, 0, 0.2f);
			mx=-0.2f;
		} 

        if (Input.GetKey(KeyCode.RightArrow) && woaking == true)
        {
          //  this.transform.Translate(0.2f, 0, 0);
		//	mx += Mathf.Clamp (0.003f, 0, 0.2f);
			mx=0.2f;
        }
        if (Input.GetKey(KeyCode.UpArrow) && woaking == true)
        {
          //  this.transform.Translate(0, 0, 0.2f);
			//	mz += Mathf.Clamp (0.003f, 0, 0.2f);
			mz=0.2f;
       	}

        if (Input.GetKey(KeyCode.DownArrow) && woaking == true)
        {
          // this.transform.Translate(0, -0, -0.2f);
			//mz -= Mathf.Clamp (0.003f, 0, 0.2f);
			mz=-0.2f;
        }


		//-------------
		if (Input.GetKey (KeyCode.LeftArrow)==false && Input.GetKey (KeyCode.RightArrow)==false&&Input.GetKey (KeyCode.UpArrow)==false && Input.GetKey (KeyCode.DownArrow)==false) 
		{
			mx /=1.2f;
			mz /=1.2f;
		}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pin, new Vector3(me.x, 0, me.z), Quaternion.identity);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
          
        }
    }
}
