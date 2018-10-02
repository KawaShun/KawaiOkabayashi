using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Director : MonoBehaviour
{
    //スコア管理 蹴った　ボールが相手のゴールにはいったら+1、オウンゴール-1
    public int scoreA = 0;
   public int scoreB = 0;
   public int scoreC = 0;
   public int scoreD = 0;
    //public int id = 0;

    GameObject target;
    //public GameObject creatball;
    GameObject ball;
    private void Start()
    {
        this.ball = GameObject.Find("theball");

    }

    private void Update()
    {

    }
    public int Addcount(int id)
    {
        if (id != 1 && ball.GetComponent<ball>().lastkick == 1)
        {
            scoreA += 1;
            target = GameObject.Find("scoreA");
            target.GetComponent<Text>().text = scoreA.ToString("");
        }
        else if (id == 1 && ball.GetComponent<ball>().lastkick == 1)
        {
            scoreA -= 1;
            target = GameObject.Find("scoreA");
            target.GetComponent<Text>().text = scoreA.ToString("");
        }
        //-----------------------------------------------------------------------
        if (id != 2 && ball.GetComponent<ball>().lastkick == 2)
        {
            scoreB += 1;
            target = GameObject.Find("scoreB");
            target.GetComponent<Text>().text = scoreB.ToString("");
        }
        else if (id == 2 && ball.GetComponent<ball>().lastkick == 2)
        {
            scoreB -= 1;
            target = GameObject.Find("scoreB");
            target.GetComponent<Text>().text = scoreB.ToString("");
        }
        //-----------------------------------------------------------------------
        if (id != 3 && ball.GetComponent<ball>().lastkick == 3)
        {
            scoreC += 1;
            target = GameObject.Find("scoreC");
            target.GetComponent<Text>().text = scoreC.ToString("");
        }
        else if (id == 3 && ball.GetComponent<ball>().lastkick == 3)
        {
            scoreC -= 1;
            target = GameObject.Find("scoreC");
            target.GetComponent<Text>().text = scoreC.ToString("");

        }

        //-----------------------------------------------------------------------
        if (id != 4 && ball.GetComponent<ball>().lastkick == 4)
        {
            scoreD += 1;
            target = GameObject.Find("scoreD");
            target.GetComponent<Text>().text = scoreD.ToString("");
        }
        else if (id == 4 && ball.GetComponent<ball>().lastkick == 4)
        {
            scoreD -= 1;
            target = GameObject.Find("scoreD");
            target.GetComponent<Text>().text = scoreD.ToString("");

        }
        /* if (id == 1)
        {
            scoreA += 1;
            target = GameObject.Find("scoreA");
            target.GetComponent<Text>().text = scoreA.ToString("");
            //         Instantiate(creatball,new Vector3(0, 3, 0), Quaternion.identity);
        }

        if (id == 2)
        {
            scoreB += 1;
            target = GameObject.Find("scoreB");
            target.GetComponent<Text>().text = scoreB.ToString("");
            //         Instantiate(creatball, new Vector3(0, 10, 0), Quaternion.identity);
        }
    */
        return id;


    }
}
