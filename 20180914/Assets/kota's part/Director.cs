using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Director : MonoBehaviour
{
    //スコア管理 蹴った　ボールが相手のゴールにはいったら+1、オウンゴール-1
  //  public static int scoreA = 0;
   // public static int scoreB = 0;
    //public static int scoreC = 0;
    //p//ublic static int scoreD = 0;
    public static int[] score = { 0, 0, 0, 0 };
    //public int id = 0;

    GameObject target;
    //public GameObject creatball;
    GameObject ball;
    private void Start()
    {
        this.ball = GameObject.Find("theball");
        score[0] = 0;
        score[1] = 0;
        score[2] = 0;
        score[3] = 0;

    }

    private void Update()
    {

    }
    public int Addcount(int id)
    {
        if (id != 1 && ball.GetComponent<ball>().lastkick == 1)
        {
            // scoreA += 1;
            score[0] += 1;
            target = GameObject.Find("scoreA");
            target.GetComponent<Text>().text = score[0].ToString("");
        }
        else if (id == 1 && ball.GetComponent<ball>().lastkick == 1)
        {
            score[0] -= 1;
            target = GameObject.Find("scoreA");
            target.GetComponent<Text>().text = score[0].ToString("");
        }
        //-----------------------------------------------------------------------
        if (id != 2 && ball.GetComponent<ball>().lastkick == 2)
        {
            score[1] += 1;
            target = GameObject.Find("scoreB");
            target.GetComponent<Text>().text = score[1].ToString("");
        }
        else if (id == 2 && ball.GetComponent<ball>().lastkick == 2)
        {
            score[1] -= 1;
            target = GameObject.Find("scoreB");
            target.GetComponent<Text>().text = score[1].ToString("");
        }
        //-----------------------------------------------------------------------
        if (id != 3 && ball.GetComponent<ball>().lastkick == 3)
        {
            score[2] += 1;
            target = GameObject.Find("scoreC");
            target.GetComponent<Text>().text = score[2].ToString("");
        }
        else if (id == 3 && ball.GetComponent<ball>().lastkick == 3)
        {
            score[2] -= 1;
            target = GameObject.Find("scoreC");
            target.GetComponent<Text>().text = score[2].ToString("");

        }

        //-----------------------------------------------------------------------
        if (id != 4 && ball.GetComponent<ball>().lastkick == 4)
        {
            score[3] += 1;
            target = GameObject.Find("scoreD");
            target.GetComponent<Text>().text = score[3].ToString("");
        }
        else if (id == 4 && ball.GetComponent<ball>().lastkick == 4)
        {
            score[3] -= 1;
            target = GameObject.Find("scoreD");
            target.GetComponent<Text>().text = score[3].ToString("");

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

    public static int getscore()
    {
        return score[0];
    }
}
