using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    public int idd = 2;
    public GameObject Director;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            Debug.Log("in");
            // Destroy(other.gameObject);
            other.transform.position = new Vector3(0,5,0);
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            //  Director.GetComponent<Director>().id = 2;
            Director.GetComponent<Director>().Addcount(idd);
        }
        // Debug.Log("Goal");

    }


}
