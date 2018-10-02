using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class result : MonoBehaviour {

    
     
    GameObject textbourd;

    //static
    int[] score = { Director.score[0], Director.score[1] , Director.score[2]  ,Director.score[3] };
    //
   // int[] juni = { 0, 0, 0, 0 };
    // Use this for initialization
    void Start () {


        for (int i = 0; i > 3; i++)
        {
            score[i] = score[i];
        }
        this.textbourd = GameObject.Find("scoreTxA");
      this.textbourd.GetComponent<Text>().text =score[3].ToString();
        this.textbourd = GameObject.Find("scoreTxB");
        this.textbourd.GetComponent<Text>().text = score[2].ToString();
        this.textbourd = GameObject.Find("scoreTxC");
        this.textbourd.GetComponent<Text>().text = score[0].ToString();
        this.textbourd = GameObject.Find("scoreTxD");
        this.textbourd.GetComponent<Text>().text = score[1].ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void matome()
    {


       /* for (int i = 0; i > 3; i++)
        {
            //if (score[i] !=) 
        }
        */




        /* Pa = scorea; id1 = 1;
         if (scoreb > Pa)
         {
             Pa = scoreb;
             id1;
 }
             if (scorec > Pa) Pa = scorec;
         if (scored > Pa) Pa = scored;

         if (scorea!=Pa) Pb = scorea;
         if (scoreb > Pb) Pb = scoreb;
         if (scorec > Pb) Pb = scorec;
         if (scored > Pb) Pb = scored;

     */
    }
}
