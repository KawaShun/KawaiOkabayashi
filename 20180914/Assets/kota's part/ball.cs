using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{

    GameObject player;
   // int hit = 0;
    public Vector3 t;
    public Vector3 b = new Vector3(0, 0, 0); //ボールの座標
    Vector3 p;      //力を入れる方向の指定 (プレイヤー座標 - ボールの座標)
    Vector3 force;
  //  Vector3 min=new Vector3(0,0,0);
    public Rigidbody rigid;
    //public GameObject pin;
    GameObject VP; //ボールに入った力の表示用 (いらない)
    public float power = 0; //ボールに入る力の量

    // Rigidbody rigid;
    public float speed; //移動速度の計測用(いらない)

   public int lastkick =0; //最後に触れたプレイヤー

    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
        VP = GameObject.Find("viewpower");
        //   rigid = GameObject.Find("ball").GetComponent<Rigidbody>();

    }




    void Update()
    {
        speed = rigid.velocity.magnitude;
        VP.GetComponent<Text>().text = speed.ToString("F1");


        power = (Mathf.Abs(power * 0.3f));


    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name== "player1")
        {
            player = GameObject.Find("player1");
            lastkick = 1;
          //  hit = 1;
            t = player.GetComponent<Transform>().position;
            b = this.transform.position;
         p = b - t;
        //    p = Mathf.Clamp(b - t,b.x,b.z);
          //  power = 0;
            power = player.GetComponent<mov>().power;
            Debug.Log("hit");
            shoot();
        }
        else if (other.gameObject.name == "player2")
        {
            player = GameObject.Find("player2");
            //  hit = 1;
            lastkick = 2;
            t = player.GetComponent<Transform>().position;
            b = this.transform.position;
            p = b - t;
            //    p = Mathf.Clamp(b - t,b.x,b.z);
            //  power = 0;
            power = player.GetComponent<mov>().power;
            Debug.Log("hit");
            shoot();
        }

        else if (other.gameObject.name == "player3")
        {
            player = GameObject.Find("player3");
            lastkick = 3;
           // hit = 1;
            t = player.GetComponent<Transform>().position;
            b = this.transform.position;
            p = b - t;
            //    p = Mathf.Clamp(b - t,b.x,b.z);
            //  power = 0;
            power = player.GetComponent<mov>().power;
            Debug.Log("hit");
            shoot();
        }

        else if (other.gameObject.name == "player4")
        {
            player = GameObject.Find("player4");
            lastkick = 4;
          //  hit = 1;
            t = player.GetComponent<Transform>().position;
            b = this.transform.position;
            p = b - t;
            //    p = Mathf.Clamp(b - t,b.x,b.z);
            //  power = 0;
            power = player.GetComponent<mov>().power;
            Debug.Log("hit");
            shoot();
        }
        if (other.gameObject.tag == "pin")
        {
         //   hit = 1;
            //t = player1.GetComponent<Transform>().position;
            b = this.transform.position;
            p = b - t;

            power = Mathf.Clamp(power + 3.5f, 0, 10);
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


   //     Mathf.Clamp(rb.x,0,0)

    }
    void shoot()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();

        // rigidbodyを取得
        force = new Vector3(Mathf.Clamp(p.x,-10,10), Mathf.Clamp(p.y, -10, 10), Mathf.Clamp(p.z, -10, 10));  // 

        // rb.AddForce(0,0,0, ForceMode.Impulse);
        rb.AddForce(force * power, ForceMode.Impulse);  //ボールに力が入る

    }
}
