using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mov : MonoBehaviour
{
    public float power = 10; //プレイヤーが持ってる蹴る力(ボールにこの数値を伝える)
    bool woaking = true; //使わない

	public float mx=0; //x軸
	public float mz=0; //z軸
    public GameObject pin;
    Vector3 me;
    GameObject timer; //pinのゲージ
    float cooltime = 10; //pnのクールタイム
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
        //減速
        mx /= 1.2f;
        mz /= 1.2f;

        GameObject[] count = GameObject.FindGameObjectsWithTag("pin");
        

        if (Input.GetKeyDown(KeyCode.Space)&&count.Length<2&&cooltime>=10)
        {
            cooltime = 0;
            Instantiate(pin, new Vector3(me.x, 0, me.z), Quaternion.identity);

        }

        this.timer.GetComponent<Image>().fillAmount = cooltime/10;


    }

}
