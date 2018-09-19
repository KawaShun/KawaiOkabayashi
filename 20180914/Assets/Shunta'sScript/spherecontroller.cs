using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecontroller : MonoBehaviour {

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
        } 
    }
    
}
