using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class camera_movement : MonoBehaviour {
    public Transform player;
     public float RotSpeed = 3.0f , speed = 3.0f;
    public void FixedUpdate()
    {     
        transform.rotation = Quaternion.Slerp(transform.rotation , Quaternion.LookRotation(player.position - transform.position) ,RotSpeed * Time.deltaTime);

    }
}