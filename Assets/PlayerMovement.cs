using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveFoward = 2000f;
    public float moveSide = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, moveFoward * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(moveSide*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-moveSide*Time.deltaTime, 0, 0);
        }
    }
}
