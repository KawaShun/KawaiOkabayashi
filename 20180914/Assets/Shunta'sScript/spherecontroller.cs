using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecontroller : MonoBehaviour {
    
    public float power = 1000.0f;          //シュート係数
    public float dribblepower = 200.0f;   //ドリブル係数
    Collider objcoll;                     //オブジェクトコライダー
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
            //シュートかドリブルかランダムで決める
            int rand = Random.Range(0, 2);
            Debug.Log("mode:" + rand);
            if(rand == 0)
            {
                other.GetComponent<enemycontroller>().SetEnemyMode(enemycontroller.MODE.DRIBBLE); 
            }
            else
            {
                other.GetComponent<enemycontroller>().SetEnemyMode(enemycontroller.MODE.SHOOT);
            }

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

    }

}
