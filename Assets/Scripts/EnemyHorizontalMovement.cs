




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{


    public float movespeed = 2f;

    private Rigidbody2D rbody;
    public bool isLeft = true;



    // Use this for initialization
    void Start()
    {
        //hämtar rigidbody
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Om du trycker på H kan du flytta fienden
        if (Input.GetKeyDown(KeyCode.H))
        {
            Move();
        }
    }
    void Move(bool flip = true)
    {
        //= lika med == jämför
        if (flip == true)
        {
            isLeft = !isLeft;
        }
        // Om ileft är sann ändrast scalan till 1,1,1, detta gör så den går höger
        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-movespeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        //Om den inte är det ändrast x värdet till -, det gör så att enemy går vänster
        {
            rbody.velocity = new Vector2(movespeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    // Om den rör något som har tagen InvisibleflipWall så vänder fienden håll
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleflipWall")
        {
            Move(true);
        }
    }
}
