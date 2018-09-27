using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecontroller : MonoBehaviour {
    
    public float power = 1000.0f;          //シュート係数
    public float dribblepower = 200.0f;   //ドリブル係数
    Collider objcoll;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //当たり判定
    private void OnTriggerEnter(Collider other)
    {
        //ゴール
        if (other.gameObject.tag == "goal")
        {
            Debug.Log("検知しました");
        }
        //敵
        if (other.gameObject.tag == "enemy")
        {
            Debug.Log("enemyと衝突");
            //吹っ飛ぶ
            Vector3 dir = transform.position - other.gameObject.transform.position;
            dir.Normalize();

            //シュートとドリブルの力の大きさ
            if (other.GetComponent<enemycontroller>().GetEnemyMode() == enemycontroller.MODE.DRIBBLE)
            {
                GetComponent<Rigidbody>().AddForce(dir * dribblepower);
            }
            else
            {
                GetComponent<Rigidbody>().AddForce(dir * power);

            }



        }
        if (other.gameObject.tag == "ground")
        {
            Debug.Log("床検知");
            objcoll = gameObject.GetComponent<SphereCollider>();
            objcoll.isTrigger = false;
        }

    }

}
