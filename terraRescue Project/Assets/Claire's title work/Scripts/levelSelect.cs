using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSelect : MonoBehaviour
{
	public Vector3 targetPos;
    public float Xincrement;
    public float speed;
    public float maxDistance;
    public float minDistance;
    public int zPos = -1;

    void Start()
    {
        
    }

    void Update()
    {
    	 transform.position = Vector3.MoveTowards(transform.position, targetPos, speed + Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x >= minDistance) {
            targetPos = new Vector3(transform.position.x - Xincrement, transform.position.y, zPos);
        } else if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.y <= maxDistance){
                    targetPos = new Vector3(transform.position.x + Xincrement, transform.position.y, zPos);
        
        }
    }
}
