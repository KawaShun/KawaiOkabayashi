using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour {

    public GameObject player1;
    int hit = 0;
    Vector3 t  ;
   public Vector3 b=new Vector3(0,0,0);
    Vector3 p ;
    Vector3 force;
    public Rigidbody rb;

    public   float power = 0;
    void Start () {
        rb = this.GetComponent<Rigidbody>();

    
    }



   
    void Update () {
        
        
        power =(Mathf.Abs(power*0.3f));
      //  float x = Input.GetAxis("Horizontal") * power*6;
      //  float y = Input.GetAxis("Vertical") * power*6;
    //    rb.AddForce(x, 0, y);


    }
    
    private void OnTriggerEnter(Collider other)
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
