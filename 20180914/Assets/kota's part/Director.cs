using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Director : MonoBehaviour
{

    int scoreA = 0;
    int scoreB = 0;
    //public int id = 0;

    GameObject target;
   public GameObject creatball;
    public int Addcount(int id)
    {
        if (id == 1)
        {
            scoreA += 1;
            target = GameObject.Find("scoreA");
            target.GetComponent<Text>().text = scoreA.ToString("");
            Instantiate(creatball,new Vector3(0, 3, 0), Quaternion.identity);
        }

        if (id == 2)
        {
            scoreB += 1;
            target = GameObject.Find("scoreB");
            target.GetComponent<Text>().text = scoreB.ToString("");
            Instantiate(creatball, new Vector3(0, 10, 0), Quaternion.identity);
        }
        return id;
    }
}
