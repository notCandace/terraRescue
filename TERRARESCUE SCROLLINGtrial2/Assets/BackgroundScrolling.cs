using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{

    Material material;
    Vector2 offset;
    public float speed = 0.1f;

    public int xVelocity, yVelocity;



    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    void Start()
    {

        offset = new Vector2(xVelocity, yVelocity);
    }

    // Update is called once per frame
    void Update()
    {

        material.mainTextureOffset += offset * Time.deltaTime * speed;

    }
}
