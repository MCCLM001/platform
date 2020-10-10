using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float xspeed;
    public float yspeed;
    private Rigidbody2D rb;
    private float mx = 0;
    private float my = 0;
    private bool gd = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gd)
        {
            my = yspeed;
            gd = false;
        } else if(Input.GetKeyUp(KeyCode.Space) || !gd){
            my = 0;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            mx = -xspeed;
        } else if (Input.GetKeyUp(KeyCode.A))
        {
            mx = 0;
        }
        if (Input.GetKeyDown(KeyCode.D)){
            mx = xspeed;
        } else if (Input.GetKeyUp(KeyCode.D))
        {
            mx = 0;
        }
        

        rb.velocity = new Vector2(mx, rb.velocity.y);
        rb.velocity += Vector2.up * my;

        //rb.AddForce (new Vector2(0, my));
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        gd = true;
    }
}
