using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rBody;
    public SpriteRenderer render;
    public GroundSensor sensor;
    public float movementSpeed = 10;
    public float jumpForce = 10;
    private float inputHorizontal;
    public bool jump = false;


    void Awake ()
    {
        rBody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
    }  

    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");

        if(Input.GetButtonDown("Jump") & sensor.isGrounded == true)
        {
            rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if(inputHorizontal < 0)
        {
            render.flipX = true;
        }
        if(inputHorizontal > 0)
        {
            render.flipX = false;
        }

    }

    void FixedUpdate()
    {
        rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y);
    }
}
