﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shooting : MonoBehaviour
{
    public float range=10;
    public GameObject bullet;
    public float speed=2;
    public enemy_dying enemydying;    
    // Update is called once per frame
   public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           shoot();
         }
    }


public void shoot ()
{
    RaycastHit hit;
  if(Physics.Raycast(transform.position,transform.forward,out hit,range))
    {
     Debug.Log(hit.transform.name);
      }
     
GameObject newbullet = Instantiate(bullet,transform.position,transform.rotation) as GameObject;
newbullet.GetComponent<Rigidbody>().velocity = (transform.forward).normalized * speed;
if(hit.transform.name == "enemy")
{
 enemydying.healthbar();
}
     
}
}


