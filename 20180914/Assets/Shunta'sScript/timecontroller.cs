using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class timecontroller : MonoBehaviour {
    //time変数
    private float time;
    public Text timelabel;
	// Use this for initialization
	void Start () {
        //制限時間
        time = 100;
	}
	
	// Update is called once per frame
	void Update () {
        //時間表示
        timelabel.text = string.Format("{0:000}", time);

        //減少
        time -= Time.deltaTime;

        //０なら０のまま
        if (time <= 0.0f)
        {
            time = 0;
            SceneManager.LoadScene("rizaruto");
        }
	}
}
