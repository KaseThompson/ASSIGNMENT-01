using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager2 : MonoBehaviour
{


    Rigidbody2D rigbody2d;
    SpriteRenderer spriteRend;
    Animator p1Animate;

    // declare variables 
    // we need a rigid body reference
    // sprite renderer
    // and and animator reference

    // Use this for initialization
    void Start()
    {
        // show text that class is running

        Debug.Log("Test: Player Manager reporting!");

        rigbody2d = GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();
        p1Animate = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {








        // change john 1, 2, and 3 to blue's sprite 






        if (Input.GetKey("up"))
        {


            rigbody2d.velocity = new Vector2(0, 2);
            spriteRend.flipY = false;
            p1Animate.Play("play2Up");

        }
        else if (Input.GetKey("down"))
        {
            rigbody2d.velocity = new Vector2(0, -2);
            spriteRend.flipY = true;
            p1Animate.Play("play2Up");
        }

        else if (Input.GetKey("right"))
        {
            rigbody2d.velocity = new Vector2(2, 0);
            spriteRend.flipX = true;
            p1Animate.Play("play2Side");


        }
        else if (Input.GetKey("left"))
        {
            rigbody2d.velocity = new Vector2(-2, 0);
            spriteRend.flipX = false;
            p1Animate.Play("play2Side");
        }
        else
                {
            rigbody2d.velocity = new Vector2(0, 0);
            p1Animate.Play("");
        }

    }
}
