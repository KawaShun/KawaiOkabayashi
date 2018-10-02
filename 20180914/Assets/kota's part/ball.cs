using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{

    GameObject player;
    public Vector3 t;
    public Vector3 b = new Vector3(0, 0, 0); //ボールの座標
    Vector3 p;                               //力を入れる方向の指定 (プレイヤー座標 - ボールの座標)
    Vector3 force;
    public Rigidbody rigid;
    GameObject VP;                          //ボールに入った力の表示用 (いらない)
    public float power = 0;                  //ボールに入る力の量
    public float speed;                     //移動速度の計測用(いらない)
    public int lastkick = 0;                      //最後に触れたプレイヤー

    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
        VP = GameObject.Find("viewpower");
    }

    void Update()
    {
        speed = rigid.velocity.magnitude;
        VP.GetComponent<Text>().text = speed.ToString("F1");
        power = (Mathf.Abs(power * 0.3f));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "player1")
        {
            player = GameObject.Find("player1");
            lastkick = 1;

            t = player.GetComponent<Transform>().position;
            b = this.transform.position;
            p = b - t;
            power = player.GetComponent<mov>().power;
            Debug.Log("hit");
            shoot();
        }
        else if (other.gameObject.name == "player2")
        {
            player = GameObject.Find("player2");

            lastkick = 2;
            t = player.GetComponent<Transform>().position;
            b = this.transform.position;
            p = b - t;

            power = player.GetComponent<mov>().power;
            Debug.Log("hit");
            shoot();
        }

        else if (other.gameObject.name == "player3")
        {
            player = GameObject.Find("player3");
            lastkick = 3;

            t = player.GetComponent<Transform>().position;
            b = this.transform.position;
            p = b - t;

            power = player.GetComponent<mov>().power;
            Debug.Log("hit");
            shoot();
        }

        else if (other.gameObject.name == "player4")
        {
            player = GameObject.Find("player4");
            lastkick = 4;

            t = player.GetComponent<Transform>().position;
            b = this.transform.position;
            p = b - t;

            power = player.GetComponent<mov>().power;
            Debug.Log("hit");
            shoot();
        }
        if (other.gameObject.tag == "pin")
        {

            b = this.transform.position;
            p = b - t;

            power = Mathf.Clamp(power + 3.5f, 0, 10);
            Debug.Log("hitthepin");
            shoot();

        }
        //y軸を固定する
        if (other.gameObject.tag == "field")
        {
            rigid.constraints = RigidbodyConstraints.FreezePositionY;
        }

    }
    //フリーズ解除
    public void FreezeRelease()
    {
        rigid.constraints = RigidbodyConstraints.None;
    }
    void shoot()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        force = new Vector3(Mathf.Clamp(p.x, -10, 10), Mathf.Clamp(p.y, -10, 10), Mathf.Clamp(p.z, -10, 10));  // 
        rb.AddForce(force * power, ForceMode.Impulse);  //ボールに力が入る
    }
}
