using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{

    public bool isGrounded;

    public PlayerMovement PlayerScript;

    void Awake()
    {
        PlayerScript = GetComponentInParent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        isGrounded = false;
    }
}
