using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour {

    public GameObject player1;
    int hit = 0;
   public Vector3 t  ;
   public Vector3 b=new Vector3(0,0,0);
    Vector3 p ;
    Vector3 force;
    public Rigidbody rigid;
    //public GameObject pin;
    GameObject VP;
    public   float power = 0;

   // Rigidbody rigid;
   public float speed;
    void Start () {
        rigid = this.GetComponent<Rigidbody>();
        VP = GameObject.Find("viewpower");
        //   rigid = GameObject.Find("ball").GetComponent<Rigidbody>();

    }




    void Update () {
        speed = rigid.velocity.magnitude;
        VP.GetComponent<Text>().text = speed.ToString("F1");


        power = (Mathf.Abs(power*0.3f));


    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            hit = 1;
            t = player1.GetComponent<Transform>().position;
            b = this.transform.position;
            p = b - t;
            power = 0;
            power = player1.GetComponent<mov>().power;
            Debug.Log("hit");
            shoot();
        }
        if (other.gameObject.tag == "pin")
        {
            hit = 1;
            //t = player1.GetComponent<Transform>().position;
            b = this.transform.position;
            p = b - t;

            power =Mathf.Clamp(speed-0.1f,0,10);
            Debug.Log("hitthepin");
            shoot();
            //      VP.GetComponent<Text>().text = p.x.ToString("F2") +","+ p.y.ToString("F2") + ","+ p.z.ToString("F2");
        }
        if (other.gameObject.tag == "wall")
        {
            Debug.Log("衝突");
           // force = new Vector3(p.x, p.y, -p.z);
           // rb.AddForce(force * power, ForceMode.Impulse);
        }
    }
    void shoot()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
         force = new Vector3(p.x, p.y, p.z);  // 力を設定


        rb.AddForce(force*power, ForceMode.Impulse);

    }
}
