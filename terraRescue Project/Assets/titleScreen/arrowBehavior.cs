using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class arrowBehavior : MonoBehaviour
{
    public Vector3 targetPos;
    public float Yincrement;
    //the value input for Yincrement decides the scale of the sprite's vertical movement.
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int zPos = -2;
    public string levelName;
    //maxHeight and minHeight prevent the sprite from moving off of the screen.
   
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
            if (transform.position.y > -1.07){
                levelName = "Play Menu";
                Debug.Log("Play screen");
            } else if (transform.position.y < -1.08){
                Debug.Log("Credits screen");
            } else if ((transform.position.y < maxHeight) && (transform.position.y > minHeight)) {
                Debug.Log("Learn more screen");
            }
            SceneManager.LoadScene(levelName);
        }

    }
}