using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public float power = 10;
    bool woaking = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && woaking == true)
        {
            this.transform.Translate(-0.2f, 0, 0);

        }
        if (Input.GetKey(KeyCode.RightArrow) && woaking == true)
        {
            this.transform.Translate(0.2f, 0, 0);

        }
        if (Input.GetKey(KeyCode.UpArrow) && woaking == true)
        {
            this.transform.Translate(0, 0, 0.2f);

        }
        if (Input.GetKey(KeyCode.DownArrow) && woaking == true)
        {
            this.transform.Translate(0, -0, -0.2f);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
          
        }
    }
}
