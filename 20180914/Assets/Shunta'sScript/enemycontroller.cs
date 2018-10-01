using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour {

    public GameObject target;
    public float moveSpeed = 1.0f;
    public GameObject enemycubepre;
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
    public void SetEnemyMode(MODE _mode)
    {
        move = _mode;
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
        transform.Translate(dir.x * moveSpeed, dir.y * moveSpeed, dir.z*moveSpeed);
        enemycubepre.transform.position = new Vector3(Mathf.Clamp(enemycubepre.transform.position.x, -14, 14),
                                                      Mathf.Clamp(enemycubepre.transform.position.y, -14, 14), 
                                                      Mathf.Clamp(enemycubepre.transform.position.z, -14, 14));

    }

}
