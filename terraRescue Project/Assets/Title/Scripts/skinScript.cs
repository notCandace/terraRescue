using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skinScript : MonoBehaviour
{
    public Vector3 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int zPos = -2;
    public string levelName;
    public GameObject kitSprite;
    public GameObject gretaSprite;
   
    void Start()
    {
        kitSprite.SetActive(true);
        gretaSprite.SetActive(false);
    }

   
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)){
            levelName = "Title screen";
        } else if (Input.GetKeyDown(KeyCode.Return)){
            levelName = "Level screen";
        }
        SceneManager.LoadScene(levelName);



        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed + Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
            targetPos = new Vector3(transform.position.x, transform.position.y + Yincrement, zPos);
        

        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight){
            targetPos = new Vector3(transform.position.x, transform.position.y - Yincrement, zPos);
        
        }


        if (transform.position.y > 3) {
            kitSprite.SetActive(true);
            gretaSprite.SetActive(false);
        	Debug.Log("Player Kit");
            } else if (transform.position.y < 3) {
                kitSprite.SetActive(false);
                gretaSprite.SetActive(true);
                Debug.Log("Player Greta");
            }

        }

    }
