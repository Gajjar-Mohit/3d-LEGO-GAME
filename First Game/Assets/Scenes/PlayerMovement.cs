using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb1;
    public float forwardForce = 2000f;
    public float sideForce = 400f;
 

    // Update is called once per frame
    void FixedUpdate()
    {
        rb1.AddForce(0, 0, forwardForce*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb1.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb1.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
