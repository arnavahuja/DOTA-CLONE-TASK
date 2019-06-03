using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    private Rigidbody rb;
    public int forcevalue = 1000;
    public float rot_speed=2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0,0,forcevalue * Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(0,0,-forcevalue * Time.deltaTime);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-forcevalue * Time.deltaTime,0,0);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(forcevalue * Time.deltaTime,0,0);
        }
        float angle = Input.GetAxis("Mouse X");
         transform.Rotate(0,angle,0);        


    }
}