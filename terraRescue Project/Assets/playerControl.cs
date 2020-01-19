using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;

    /*
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundcheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;
    */

    // Start is called before the first frame update
    void Start()
    {
        //extraJumps = extraJumpsValue;
        //rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //isGrounded = Physics2D.OverlapCircle(groundcheck.position, checkRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        }

        /*
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        if(Input.GetKeyDown("space") && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        } else if (Input.GetKeyDown("space") && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        */
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
