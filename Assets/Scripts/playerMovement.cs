using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    Vector2 movement;
    public float startTimeBtwShots;
    private float timeBtwShots;
    public GameObject shot;

    void Update()
    { 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        //Shooting for player
        if (Input.GetKeyDown("space"))
        {
            Instantiate(shot, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        } else
        {
            timeBtwShots -= Time.deltaTime;
        }
        
    }

    void FixedUpdate()
    {   //Allows the user to move
        rb.MovePosition(rb.position+ movement * speed * Time.fixedDeltaTime);



    }
}
