using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pin : MonoBehaviour {
    float c=1;
    float al=1;
    float syometu;
    float kierutime=0.3f;
    bool derete = false;

    GameObject ball;
    private void Start()
    {
        this.GetComponent<BoxCollider>().isTrigger=  true;
        al = 0.3f;
        this.ball = GameObject.Find("theball");
    }

    void Update()
	{
        //Debug.Log("true");
        c += 0.1f;
        al+= 0.1f;

        this.gameObject.GetComponent<Renderer>().material.SetColor("_Color", new Color (c, c, c, al));//= Material new Color(c, c, c, al);
        syometu += Time.deltaTime;

        if (syometu >= 1) this.GetComponent<BoxCollider>().isTrigger = false;
        if (syometu >= kierutime && derete == true) Destroy(this.gameObject);

    }

    void OnCollisionEnter(Collision other)
	{
	///	Debug.Log ("pin");
		if (other.gameObject.tag == "ball") {
            //hit = true;	
            	Debug.Log("hitpin");
            hit();
            

        }
    }
    void hit()
    {
        c = 0;
        al = 0;
        syometu = 0;
        derete = true;
        this.ball.GetComponent<ball>().t = this.transform.position;
        Debug.Log(ball.GetComponent<ball>().t);
    }
}
