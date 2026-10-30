using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterContoller : MonoBehaviour
{

    Rigidbody2D rb;
    Vector2 dir;
    public float speed = 5f;
    //public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //animator = gameObject.GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        if ((dir.x < 0) && (Input.GetButton("Horizontal")))
        {
            //animator.SetBool("left", true);
        }
        else
        {
            //animator.SetBool("left", false);
        }
        if ((dir.x > 0) && (Input.GetButton("Horizontal")))
        {
            //animator.SetBool("right", true);
        }
        else
        {
            //animator.SetBool("right", false);
        }


        dir.y = Input.GetAxisRaw("Vertical");
        if ((dir.y > 0) && (Input.GetButton("Vertical")))
        {
            //animator.SetBool("up", true);
        }
        else
        {
            //animator.SetBool("up", false);
        }
        if ((dir.y < 0) && (Input.GetButton("Vertical")))
        {
            //animator.SetBool("down", true);
        }
        else
        {
            //animator.SetBool("down", false);
        }

        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
    }
}
