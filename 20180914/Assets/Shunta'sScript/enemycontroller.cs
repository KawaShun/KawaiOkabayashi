using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour {

    public GameObject target;
    public float moveSpeed = 1.0f;
    //敵のモード
    public enum MODE
    {
        DRIBBLE,
        SHOOT
    }
    MODE move = MODE.SHOOT;

    public MODE GetEnemyMode()
    {
        return move;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 常にターゲットに向かう ---
        // 2点のベクトルを取得
        Vector3 dir = target.transform.position - transform.position;
        // 正規化
        dir.Normalize();
        // 移動させる
        transform.Translate(dir.x * moveSpeed, dir.y * moveSpeed, 0.0f);

    }
    
}
