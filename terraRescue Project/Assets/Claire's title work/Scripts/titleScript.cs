using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScript : MonoBehaviour
{
    public Vector3 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int zPos = -2;
    public string levelName;
   
    void Start()
    {

    }

   
    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed + Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
            targetPos = new Vector3(transform.position.x, transform.position.y + Yincrement, zPos);
        

        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight){
            targetPos = new Vector3(transform.position.x, transform.position.y - Yincrement, zPos);
        
        }

        if (Input.GetKeyDown(KeyCode.Return)){
            if (transform.position.y > -1.5){
                levelName = "Skin screen";
            } else if (transform.position.y < -2){
                levelName = "Credits screen";
            } else if ((transform.position.y < maxHeight) && (transform.position.y > minHeight)) {
                levelName = "Info screen";
            }
            SceneManager.LoadScene(levelName);
        }

    }
}