using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collisions : MonoBehaviour
{
    public GameObject player;
    public string levelName;
    public int score = 0;
    public Text text;

    public float speed = 0.15f;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(-1, 0, 0) * speed;
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
            levelName = "Legislature Scene";
            SceneManager.LoadScene(levelName);
            //change scene here to end credits????

        }
        else if (other.gameObject.tag == "under da sea")
        {
            levelName = "Ocean Scene";
            SceneManager.LoadScene(levelName);
            //change scene to marine level
        }
        else if (other.gameObject.tag == "down with the cows")
        {
            levelName = "Cattle Scene";
            SceneManager.LoadScene(levelName);
            //change scene to cattle level
        }
        else if (other.gameObject.tag == "collect")
        {
            other.gameObject.SetActive(false);
            score++;
            text.text = "Score " + score;
        }


    }
}
