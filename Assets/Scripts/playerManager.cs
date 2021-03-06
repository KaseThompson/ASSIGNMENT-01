﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{


    Rigidbody2D rb2d;
    SpriteRenderer spriteRen;
    Animator p1Anim;

    // declare variables 
    // we need a rigid body reference
    // sprite renderer
    // and and animator reference

    // Use this for initialization
    void Start()
    {
        // show text that class is running

        Debug.Log("Test: Player Manager reporting!");

        rb2d = GetComponent<Rigidbody2D>();
        spriteRen = GetComponent<SpriteRenderer>();
        p1Anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
       


    











        if (Input.GetKey("w"))
        {
        

            rb2d.velocity = new Vector2(0, 35);
            spriteRen.flipY = false;
            p1Anim.Play("john");

        }
        else if (Input.GetKey("s"))
        {
            rb2d.velocity = new Vector2(0, -35);
            spriteRen.flipY = false;
            p1Anim.Play("john2");
        }

        else if (Input.GetKey("d"))
        {
            rb2d.velocity = new Vector2(35, 0);
            spriteRen.flipX = false;
            p1Anim.Play("john4");


        }
        else if (Input.GetKey("a"))
        {
            rb2d.velocity = new Vector2(-35, 0);
            spriteRen.flipX = true;
            p1Anim.Play("john4");
        }

    }
}