using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignorecollision : MonoBehaviour
{
public GameObject player;
public GameObject enemy;
   
    void Start()
    {
       Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>()); 
       Physics.IgnoreCollision(enemy.GetComponent<Collider>(), GetComponent<Collider>()); 
    }

   
}
