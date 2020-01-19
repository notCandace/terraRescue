using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");

        if (other.gameObject.tag == "death")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "grapple")
        {
            //change scene here to end credits????

            //player.SetActive(false);
        }
        else if (other.gameObject.tag == "under da sea")
        {
            //change scene to marine level
        }
        else if(other.gameObject.tag == "down with the cows")
        {
            //change scene to cattle level
        }
        else if (other.gameObject.tag == "collect")
        {
            other.gameObject.SetActive(false);
        }


    }
}
