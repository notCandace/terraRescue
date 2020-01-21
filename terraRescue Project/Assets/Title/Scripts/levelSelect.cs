using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour
{
	public Vector3 targetPos;
    public float Xincrement;
    public float speed;
    public float maxDistance;
    public float minDistance;
    public int zPos = -1;
    public string levelName;

    void Start()
    {
        
    }

    void Update()
    {
        //moving the yellow bar around
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed + Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minDistance)
        {
            targetPos = new Vector3(transform.position.x - Xincrement, transform.position.y, zPos);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxDistance)
        {
            targetPos = new Vector3(transform.position.x + Xincrement, transform.position.y, zPos);

        }

        Debug.Log(transform.position.x);


        //deciding what level to land in//
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (transform.position.x == -.58f || transform.position.x == -.5799999f)
            {
                levelName = "Fire Scene";
            }
            else if (transform.position.x == 4.12f)
            {
                levelName = "Cattle Scene";
            }
            else if (transform.position.x == 8.82f)
            {
                levelName = "Legislature Scene";
            }
            else
            {
                levelName = "Ocean Scene";
            }
            SceneManager.LoadScene(levelName);

        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            levelName = "Skin screen";

            SceneManager.LoadScene(levelName);

        }

        
    }
}

