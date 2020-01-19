using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public GameObject player;

    public float speed = 0.15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");

        if (other.gameObject.tag == "death")
        {
            Destroy(gameObject);
        }
        else
        {
            player.SetActive(false);
        }

            
    }
}
