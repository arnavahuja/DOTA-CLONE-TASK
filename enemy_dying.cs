using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_dying : MonoBehaviour
{
    public  int count = 2;
     public void healthbar()
     {
       if(count==0)
       { 
        enemydie();
        }
        count--;
        if(count<0)
        {
        count=2;
        }
       }



    public void enemydie()
     {
       Destroy(this.gameObject);
      }
}
