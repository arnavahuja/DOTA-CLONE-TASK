using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_dying : MonoBehaviour
{
    public  int count = 0;
     public void healthbar()
     {
       if(count==2)
       { 
        enemydie();
        }
        count++;
        if(count>2)
        {
        count=0;
        }
       }



    public void enemydie()
     {
       Destroy(this.gameObject);
      }
}
