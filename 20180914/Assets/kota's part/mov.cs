using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mov : MonoBehaviour
{
    public float power = 10;
    bool woaking = true;

	public float mx=0;
	public float mz=0;
    public GameObject pin;
    Vector3 me;
    GameObject timer;
    float cooltime = 10;
    // Use this for initialization
    void Start()
    {
        timer = GameObject.Find("timer");
    }

    // Update is called once per frame
    void Update()
    {
        cooltime += Mathf.Clamp(Time.deltaTime,0,10);


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

     /*   if (me.y >= 5 || me.y <= -5 || me.x >= 15 || me.x <= -15)
        {
            mx = 0;
            mz = 0;

        }*/
		//-------------
		if (Input.GetKey (KeyCode.LeftArrow)==false && Input.GetKey (KeyCode.RightArrow)==false&&Input.GetKey (KeyCode.UpArrow)==false && Input.GetKey (KeyCode.DownArrow)==false) 
		{
			mx /=1.2f;
			mz /=1.2f;
            woaking = true;
        }


        GameObject[] count = GameObject.FindGameObjectsWithTag("pin");
        

        if (Input.GetKeyDown(KeyCode.Space)&&count.Length<=2&&cooltime>=10)
        {
            cooltime = 0;
            Instantiate(pin, new Vector3(me.x, 0, me.z), Quaternion.identity);

        }

        this.timer.GetComponent<Image>().fillAmount = cooltime/10;


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
          
        }
        if (other.gameObject.tag == "wall")
        {
            mx = 0;
            mz = 0;
            woaking = false;
        }
     //   else woaking = true;
    }

    void pintime()
    {
        

    }
}
